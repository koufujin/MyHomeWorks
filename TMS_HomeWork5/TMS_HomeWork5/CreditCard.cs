using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_HomeWork5
{
    public class CreditCard
    {
        Random random = new Random();   
        public string cardNumber ="Empty";
        public string name;
        public string secondName;
        public int cash = 0;
        public CreditCard(string name, string secondName)
        { 
            this.name = name;
            this.secondName = secondName;
        }
        public void TakeCash(int ammount)
        {
                if(cash < ammount && cash > 0)
                {
                    Console.WriteLine("Недостаточно средств!");
                }
                else if (cash <= 0)
                {
                Console.WriteLine("У вас на счёту нет средств!");
                }
                else
                {
                cash = cash - ammount;
                Console.WriteLine($"Вы успешно сняли {ammount}$\nУ вас на счету {cash}$");
                }
        }
        public void AddCash(int ammount)
        {
            cash += ammount;
            Console.WriteLine();    
        }
        public string CreateCardNumber()
        {
            if (cardNumber == "Empty")
            {
                cardNumber = "";
                for (int i = 0; i < 20; i++)
                {
                    cardNumber = cardNumber + random.Next(0, 10).ToString();
                }
                Console.WriteLine($"Счет создан, ваш номер: {cardNumber}");
                return cardNumber;
            }
            else
            {
                Console.WriteLine("У вас уже есть счёт!");
                return cardNumber;
            }
            
        }
        public void ShowAccountStatus()
        {
            if (cardNumber == "Empty")
            {
                Console.WriteLine($"Создайте счёт командой: CreateCardNumber");
            }
            else
            {
                Console.WriteLine($"Уважаемый(ая) {name} {secondName} на счету {cardNumber} // {cash}$");
            }
        }
    }
}
