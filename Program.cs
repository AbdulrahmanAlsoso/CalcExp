using System;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using CalcExp.Data;
using CalcExp.Entities;
using CulcExp.Entities;
namespace CalcExp
{
    public class Tester{
        public static void Main(){
            Tester.Start();
        }

        private static void Start(){
            User validUser ;
            do{
                validUser =UserManagement.login();
            }while(validUser==null||(validUser.Name==""&&validUser.Password==""));
            showOption(validUser);
        }

        private static void showOption(User user){
            var optionKey = 'i';
            do{
               printOption();
                 char.TryParse( Console.ReadLine(),out optionKey);
                if (optionKey == null)
                {
                    Utility.PrintMessage("pleas enter option letter.", ConsoleColor.Red);
                    continue;
                }

                switch (optionKey){
                    case 'A':
                        Console.WriteLine("option A. ");
                        Console.ReadKey();
                        break;
                }
            }while(optionKey!='E');
            Utility.PrintMessage("The app is exiting.", ConsoleColor.Magenta);
            Console.ReadKey(true);
        }

        private static void printOption(){
            Console.Clear();
            System.Console.WriteLine($"     -----Options-----");
            System.Console.WriteLine($"E- Enter (E) letter to exit.");
            System.Console.WriteLine($"pleas attention about case sensetiv.");
        }
        
    }
}
