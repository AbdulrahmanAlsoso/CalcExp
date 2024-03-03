using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using CalcExp;
using CalcExp.Data;
using CulcExp.Entities;

public static class UserManagement{
    public static User login(){
            System.Console.Write("Enter your user name :");
            var userNameInput = Console.ReadLine();
            System.Console.Write("Enter your user passowrd :");
            var userPassowrdInput = Utility.ReadPassword();
            User user= new User(userNameInput,userPassowrdInput); 
            var validUser = new User();
            if (user !=null && (user.Name!=""&&user.Password!=""))
            {
                try{

                using(AppDBContext dBContext = new AppDBContext()){
                    validUser= dBContext.users.FirstOrDefault
                    (u => u.Name==user.Name &&
                     u.Password ==user.Password);
                    Utility.printDotAnimation();
                    Console.ReadKey(true);
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
                Console.ReadKey(true);
            }
        }   
        Utility.printDotAnimation();
        Utility.PrintMessage("Fital this is incorect user or passowrd.",ConsoleColor.Red);
        Console.ReadKey();
        return null;
    }
}