using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumachokokokokok
{
    enum AccountType { Current, Savings }
    class Bank
    {
        int AccountNumber;
        double Balance;
        AccountType Type;
        public Bank(int AccountNumber, double Balans, AccountType Type)
        {
            this.AccountNumber = AccountNumber;
            this.Balance = Balans;
            this.Type = Type;
        }
        public string GetAndSetAccountNumber { get; set; }
        public double GetAndSetBalance { get { return Balance; } set { Balance = value; } }
        public AccountType GetAndSetType { get; set; }
        public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {Balance}, Type - {Type}";

        static Random rand = new Random();
        private static int generic_number = rand.Next(0, 10000000);
        public int Generic
        {
            get { return generic_number; }
            set { value = generic_number++; }
        }
        public void PutOnAnotherBalance(ref Bank ac, ref double sum)
        {
            ac.Balance += sum;
            sum = 0;
        } /// <summary>
          /// ////////////////////////////8_1
          /// </summary>
        public void PutOnBalance()
        {
            Console.Write("Введите сумму для зачисления ");
            Balance += double.Parse(Console.ReadLine());
        }
        public void PutOutBalance()
        {
            Console.Write("Введите сумму для снятия ");
            try
            {
                double temp = Convert.ToDouble(Console.ReadLine());
                if (Balance >= temp)
                    Balance = Balance - temp;
                else
                {
                    Console.WriteLine("На вашем счёте недостаточно средств(...");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
    class Song
    {
        string? name;
        string? author;
        Song prev;
        public string GetInfo 
        {
            get { return $"{name} - {author}. Предыдущая Песня:{this.prev?.Title() ?? "Отсутствует"}"; }
        }
        public void NewName(string name)
        {
            this.name = name;
        }
        public void NewAuthor(string author)
        {
            this.author = author;
        }
        public void NewPrev(Song prev)
        { this.prev = prev; }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public override bool Equals(object d)
        {
            return (ReferenceEquals(d, this));
        }
        public bool Equals(Song f)
        {
            return f.GetInfo == this.GetInfo;
        }


    }
}
