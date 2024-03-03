namespace CalcExp
{
    public class User{
            public string Name { get;private set; }
            public string Password {get ;private set;}
            public User(){}
            public User (string name , string password){
                this.Name = name;
                this.Password =password;
            }
        }
}
