using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNomadApp
{

    public class Registration
    {
        public Registration()
        {

            using (var context = new UserContext())
            {
                int firstSub = 12;
                int secondSub = 24;
                int thirdSub = 36;

                int firstSumm = 1500;
                int secondSumm = 2500;
                int thirdSumm = 4000;

                Console.Write("Введите логин: ");
                var login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                var password = Console.ReadLine();

                Console.Write("Введите город: ");
                var city = Console.ReadLine();

                Console.Write("Введите адрес: ");
                var adress = Console.ReadLine();

                Console.Write("Введите номер карточки: ");
                var cardnumber = Console.ReadLine();


                Console.WriteLine("1." + firstSub + "мес - " + firstSumm + "тг");
                Console.WriteLine("2." + secondSub + "мес - " + secondSumm + "тг");
                Console.WriteLine("3." + thirdSub + "мес - " + thirdSumm + "тг");

                Console.Write("Выберите срок подписки: ");
                int selectNumber = int.Parse(Console.ReadLine());

                int subscription = 0;
                int summa = 0;

                if (selectNumber == 1)
                {
                    subscription = firstSub;
                    summa = firstSumm;
                }
                else if (selectNumber == 2)
                {
                    subscription = secondSub;
                    summa = secondSumm;
                }
                else if (selectNumber == 3)
                {
                    subscription = thirdSub;
                    summa = thirdSumm;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }


////////////////////////////////////////////////////////////////////////////////////////
                string journal  ;

                foreach (var journals in context.Journals)
                {
                    journal = journals.Name;
                }

                var newUser = new Users
                {
                    Login = login,
                    Password = password,
                    City = city,
                    Adress = adress,
                    CardNumber = cardnumber,
                    Subscription = subscription,
                    SummWallet = summa,
                    BuyDate = DateTime.Today,
                   // не получается присвоить журнал при регистрации
                   //Journal = journal

                };
///////////////////////////////////////////////////////////////////////////////////////////
                context.Users.Add(newUser);


                context.SaveChanges();

            }
        }
    }
}
