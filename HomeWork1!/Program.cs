using System;

namespace Home
{
    class Program
    {

        static void Main(string[] args)
        {
            Employer Direc = new Employer("", "Генеральный директор", "Борис");
            //Бухгалтеры
            Employer BushUp = new Employer(Direc, "Бухгалтерия", "Финансовый Директор", "Рашид");
            Employer BushDown = new Employer(BushUp, "Бухгалтерия", "Бухгалтер", "Лукас");

            //DevOps
            Employer DirecAuto = new Employer(Direc, "Информационые технологии", "Директор по автоматизации", "О Ильхам");
            Employer BossIT = new Employer(DirecAuto, "Информационые технологии", "Начальник инф систем", "Оркадий");
            Employer ZamBossIt = new Employer(BossIT, "Информационые технологии", "Зам.начальника", "Володя");
            Employer BossDevOps = new Employer(ZamBossIt, "Cистемщики", "Главный в секторе системщиков", "Ильшат");
            Employer ZamBossDevOps = new Employer(BossDevOps, "Cистемщики", "Зам.Сектора системщиков", "Иваныч");//
            Employer DevOps1 = new Employer(ZamBossDevOps, "Системщики", "Работник", "Илья");
            Employer DevOps2 = new Employer(ZamBossDevOps, "Системщики", "Работник", "Витя");
            Employer DevOps3 = new Employer(ZamBossDevOps, "Системщики", "Работник", "Женя");

            //Developers
            Employer BossDevelop = new Employer(ZamBossIt, "Разработка", "Главный секторе разработчиков", "Сергей");//
            Employer ZamBossDevelop = new Employer(BossDevelop, "Разработка", "Зам.Сектора Разработки", "Ляйсан");
            Employer Developer1 = new Employer(ZamBossDevelop, "Разработка", "Работник", "Марат");
            Employer Developer2 = new Employer(ZamBossDevelop, "Разработка", "Работник", "Дина");
            Employer Developer3 = new Employer(ZamBossDevelop, "Разработка", "Работник", "Ильдар");
            Employer Developer4 = new Employer(ZamBossDevelop, "Разработка", "Работник", "Антон");

            Employer Check(string nameRole)
            {
                switch (nameRole.ToLower())
                {
                    case ("борис-генеральный директор"):
                        return Direc;
                    case "рашид-финансовый директор":
                        return BushUp;
                    case "лукас-бухгалтер":
                        return BushDown;
                    case "о ильхам-директор по автоматизации":
                        return DirecAuto;
                    case "оркадий-начальник инф систем":
                        return BossIT;
                    case "володя-зам.начальника":
                        return ZamBossIt;
                    case "ильшат-главный в секторе системщиков":
                        return BossDevOps;
                    case "иваныч-зам.сектора системщиков":
                        return ZamBossDevOps;
                    case "илья-работник-системщики":
                        return DevOps1;
                    case "витя-работник-системщики":
                        return DevOps2;
                    case "женя-работник-системщики":
                        return DevOps3;

                    case "сергей-главный в секторе разработчиков":
                        return BossDevelop;
                    case "ляйсан-зам.сектора разработки":
                        return ZamBossDevelop;
                    case "марат-работник-разработка":
                        return Developer1;
                    case "дина-работник-разработка":
                        return Developer2;
                    case "ильдар-работник-разработка":
                        return Developer3;
                    case "антон-работник-разработка":
                        return Developer4;
                    default:
                        return null;
                }
            }
            Console.Write("Введите имя-должность(через дефис), того, КОМУ хотите выдать задачу(Если человек является разработчиком или системщиком, введите имя-должность-сектор):");
            string input1 = Console.ReadLine();
            Console.Write("Введите имя-должность(через дефис), того, КТО хочет выдать задачу(Если человек является разработчиком или системщиком, введите имя-должность-сектор):");
            string input2 = Console.ReadLine();

            if (Check(input1)?.GetHead == Check(input2)?.GetTitle && Check(input1)?.GetHead != null && Check(input2)?.GetTitle != null)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO, возможно, такого работника не существует.");

        }
    }
}

