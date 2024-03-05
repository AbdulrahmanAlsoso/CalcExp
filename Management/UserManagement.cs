using System;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Threading;
using CalcExp;
using CalcExp.Data;
using CulcExp.Entities;

public static class UserManagement{
    public static User login(){
        Console.Clear();
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
                    validUser= dBContext.Users.FirstOrDefault
                    (u => u.Name==user.Name &&
                     u.Password ==user.Password);
                    if (validUser != null) { 
                    Utility.printDotAnimation();
                    Utility.PrintMessage("login successfully.",ConsoleColor.Green);
                        Thread.Sleep(1000);
                    return validUser;
                    }
                }
                }
                catch(Exception ex){
                    Console.WriteLine(ex.Message);
                    Console.ReadKey(true);
                }
        }
        Utility.printDotAnimation();
        Utility.PrintMessage("Fital this is incorect user or passowrd.",ConsoleColor.Red);
        Thread.Sleep(3000);
        Console.Clear();
        return null;   
    }
}