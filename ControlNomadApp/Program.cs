using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlNomadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserContext())
            {
                Console.WriteLine("1. Войти");
                Console.WriteLine("2. Регистрация");
                int selectNumber = int.Parse(Console.ReadLine());

                if (selectNumber == 1)
                {
                    Login login = new Login();
                }

                else if (selectNumber == 2)
                {
                    Registration registration = new Registration();
                }
            }

        }
    }
}
