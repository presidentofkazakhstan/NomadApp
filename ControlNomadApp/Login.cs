using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNomadApp
{
    public class Login
    {
        public Login()
        {
            using (var context = new UserContext())
            {


                Console.Write("Введите логин: ");
                var login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();


                if (login == "admin" && password == "superadmin")
                {
                    Console.WriteLine("1. Запустить новый журнал");
                    Console.WriteLine("2. Начать достаку журналов");
                    Console.WriteLine("3. Отчет");
                    int number = int.Parse(Console.ReadLine());
                    if(number == 1)
                    {
                        AddNewJournal addNewJournal = new AddNewJournal();
                    }
                    else if(number == 2)
                    {
                        DeliveryJournals deliveryJournals = new DeliveryJournals();
                    }
                    
                }



                foreach (var user in context.Users)
                {

                    if (login == user.Login && password == user.Password)
                    {
                        Console.WriteLine("Login: " + user.Login + "\nPassword: " + user.Password + "\nCity:" + user.City + "\nAdress: " + user.Adress + "\nCard Number: " + user.CardNumber + "\nSubcription: " + user.Subscription + "\nDate: " + user.BuyDate + "\nPay: " + user.SummWallet);

                    }

                    Console.WriteLine("Отменить подписку?");
                    Console.WriteLine("1. Да");
                    Console.WriteLine("2. Нет");

                    int selectNumber = int.Parse(Console.ReadLine());

                    if (selectNumber == 1)
                    {
                        user.Subscription = 0;
                        user.SummWallet = 0;
                    }
                    else
                    {
                        Console.WriteLine("Спасибо");
                    }
                }

                context.SaveChanges();

            }
        }
    }
}
