using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Tumachokokokokok;

namespace Tumach
{
    class Program
    {
        ////8_1 в библиотеке!

        static string? DoEx8_2(ref string str)
        {
            string? str2 = null;
            for (int i = 0; i < str?.Length; i++)
            {
                str2 += str[^(i + 1)];
            }
            return str2;
        }
        static void DoEx8_3(string p1, string p2)
        {
            try
            {

                StreamWriter writer = new StreamWriter(p1, true);
                StreamReader reader = new StreamReader(p2);
                string t = reader.ReadToEnd();
                writer.WriteLine(t);
                //Console.WriteLine(n);
                writer.Close(); reader.Close();
            }
            catch
            {
                Console.WriteLine("Чел, ты кринж, реальна..");
            }

        }


        public bool IsFormattableImplemented(object param) => param is IFormattable;//8_4
        public bool IsFormattableImplemented(object param, int k = 5) => param as IFormattable != null; // 8_4
        static void Main(string[] args)
        {

            string str = null;//--------------______________---------------------__________ 2
            string str2 = DoEx8_2(ref str);
            Console.WriteLine(str2);

            string p = @"C:\Users\Никита\Desktop\t.txt";
            string p2 = @"C:\Users\Никита\Desktop\fakk\Parser\Tumachokokokokok\TextFile1.txt";
            DoEx8_3(p, p2);
            static void DoEx8__1(string path)
            {
                var p = File.ReadAllText(path);
                var r = Regex.Matches(p, @"([a-z]+@[a-z]*.ru)");
                Console.WriteLine(String.Join("\n", r));
            } //похвастаться :D
            DoEx8__1(@"C:\Users\Никита\Desktop\fakk\Parser\Tumachokokokokok\TextFile1.txt");  //задание 8__1)
 

            Song SwadowRaze = new Song(); SwadowRaze.NewAuthor("SwadowRaze"); SwadowRaze.NewName("ShowDown");//рейзик со своим хитом)
            Song SuicideBoys = new Song(); SuicideBoys.NewAuthor("$uicideBoy$"); SuicideBoys.NewName("Paris"); SuicideBoys.NewPrev(SwadowRaze);
            Song PapinOlimpos = new Song(); PapinOlimpos.NewAuthor("Папин Олимпос"); PapinOlimpos.NewName("Айсберг"); PapinOlimpos.NewPrev(SuicideBoys);
            Song PapinOlimpos2 = new Song(); PapinOlimpos2.NewAuthor("Папин Олимпос"); PapinOlimpos2.NewName("Снежинка"); PapinOlimpos2.NewPrev(PapinOlimpos);
            List<Song> songs = new List<Song> { SwadowRaze, SuicideBoys, PapinOlimpos, PapinOlimpos2 };
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].GetInfo); //похвастаться :D getinfo
            }
        }


    }
}