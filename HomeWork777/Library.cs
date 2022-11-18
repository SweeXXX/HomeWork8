using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork777
{

    internal class Boris 
    {
        internal int id;
        internal string name;
        

        internal Boris(string name)
        {
            this.id = 0;
            this.name = name;
        }
    }
    internal class Oiliham : Boris
    {
        internal Oiliham(string name) : base(name) { id = 1; this.name = name; }
    }
    
    internal class Orkadii : Oiliham
    {
        internal Orkadii(string name) : base(name) { id = 2; this.name = name; }
    }
    internal class Volodya : Orkadii
    {
        internal Volodya(string name) : base(name) { id = 3; this.name = name; }
    }
    internal class Ilishat : Volodya
    {
        internal Ilishat(string name) : base(name) { id = 4; this.name = name; }
    }
    internal class Ivanich : Ilishat
    {
        internal Ivanich(string name) : base(name) { id = 5; this.name = name; }
    }
    internal class Ilya : Ivanich
    {
        internal Ilya(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Vitya : Ivanich
    {
        internal Vitya(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Zenya : Ivanich
    {
        internal Zenya(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Sergay : Volodya
    {
        internal Sergay(string name) : base(name) { id = 4; this.name = name; }
    }
    internal class Lyasan : Sergay
    {
        internal Lyasan(string name) : base(name) { id = 5; this.name = name; }
    }
    internal class Marat : Lyasan
    {
        internal Marat(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Dina : Lyasan
    {
        internal Dina(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Ildar : Lyasan
    {
        internal Ildar(string name) : base(name) { id = 6; this.name = name; }
    }
    internal class Anton : Lyasan
    {
        internal Anton(string name) : base(name) { id = 6; this.name = name; }
    }


    /// <summary>
    /// Бухгалтеры
    /// </summary>
    internal class Rashid : Boris
    {
        internal Rashid(string name) : base(name) { id = 1; this.name = name; }
    }
    internal class Lukas : Rashid
    {
        internal Lukas(string name) : base(name) { id = 2; this.name = name; }
    }


    public class Library
    {
        static internal Boris? Who(string s)
        {
            switch(s)
            {
                case "Борис": return new Boris("Борис");
                case "Рашид": return new Rashid("Рашид");
                case "Лукас": return new Lukas("Лукас");
                case "О Ильхам": return new Oiliham("О Ильхам");
                case "Оркадий": return new Orkadii("Оркадий");
                case "Володя": return new Volodya("Володя");
                case "Ильшат": return new Ilishat("Ильшат");
                case "Сергей": return new Sergay("Сергей");
                case "Иваныч": return new Ivanich("Иваныч");
                case "Ляйсан": return new Lyasan("Ляйсан");
                case "Илья": return   new Ilya("Илья");
                case "Витя": return   new Vitya("Витя");
                case "Женя": return   new Zenya("Женя");
                case "Марат": return  new Marat("Марат");
                case "Ильдар": return new Ildar("Ильдар");
                case "Дина": return   new Dina("Дина");
                case "Антон": return  new Anton("Антон");
                default: return null;
            }
        }
    }
}
