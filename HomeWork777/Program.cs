using System;
using HomeWork777;
namespace Home
{
    class Program
    {
        static public bool YesOrNo(string str1, string str2)
        {
            try
            {
                var r1 = Library.Who(str1);
                var r2 = Library.Who(str2);
                if (r2.id - r1.id == 1)
                {
                    if (r2.GetType().IsSubclassOf(r1.GetType()))
                        return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        static void Main(string[] ars)
        {
            var boris = new Boris("Борис");
            var rashid = new Rashid("Рашид");
            var lukas = new Lukas("Лукас");
            var oiliham = new Oiliham("О Ильхам");
            var orkadii = new Orkadii("Оркадий");
            var volodya = new Volodya("Володя");
            var ilishat = new Ilishat("Ильшат");
            var sergay = new Sergay("Сергей");
            var ivanich = new Ivanich("Иваныч");
            var lyasan = new Lyasan("Ляйсан");
            var ilya = new Ilya("Илья");
            var vitya = new Vitya("Витя");
            var zenya = new Zenya("Женя");
            var marat = new Marat("Марат");
            var ildar = new Ildar("Ильдар");
            var dina = new Dina("Дина");
            var anton = new Anton("Антон");

            Console.WriteLine("Введите кто дает задачу, какую задачу, кому Дает Задачу(через Запятую):");
            string[] s = Console.ReadLine().Replace(" ","").Split(",").ToArray();
            var r1 = Library.Who(s[0]);
            var r2 = Library.Who(s[2]);
            if(YesOrNo(s[0], s[2]))
            {
                Console.WriteLine($"{s[2]} Берет Задачу: \"{s[1]}\" От {s[0]}");
            }
            else
            {
                Console.WriteLine($"{s[2]} НЕ Берет Задачу: \"{s[1]}\" От {s[0]}");
            }





        }
    }
}