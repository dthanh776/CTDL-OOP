using System;

class Admin
{
    //Fields
    private string user;
    private string password;

    public string User
    {
        get
        {
            return user;
        }

        set
        {
            user = value;
        }
    }

    public string Password
    {
        get
        {
            return password;
        }

        set
        {
            password = value;
        }
    }



    //Constructor
    public Admin(string User, string Pass)
    {
        this.User = User;
        this.Password = Pass;

    }
    public Admin()
    {
        this.User = User;
        this.Password = Password;
    }
    //toString
    public string toString()
    {
        return $"{User,-15}{Password,-15}";
    }
    
}
