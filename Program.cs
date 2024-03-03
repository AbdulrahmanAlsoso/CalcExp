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
            Console.Clear();
            do{
                validUser =UserManagement.login();
                Console.Clear();
            }while(validUser==null||(validUser.Name==""&&validUser.Password==""));
            showOption(validUser);
        }
        private static void showOption(User user){
            var optionKey = 'i';
            printOption();
            do{
                switch (optionKey){
                    case 'A':
                        break;
                    default:Utility.PrintMessage("pleas enter option letter.",ConsoleColor.Red);
                        break;
                }
            }while(optionKey=='E');
        }
        private static void printOption(){
            System.Console.WriteLine($"     -----Options-----");
            System.Console.WriteLine($"E- Enter (E) letter to exit.");
            System.Console.WriteLine($"pleas attention about case sensetiv.");
        }
        
    }
}
