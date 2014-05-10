using System;
using SKYPE4COMLib;

public class User
{
    private string UserName;
    lis

    public User(Skype skype)
	{
        SetUser(skype.CurrentUserProfile.FullName);
	}

    public void SetUser(string name)
    {
        this.UserName = name;
    }

    public string GetUser()
    {
        return this.UserName;
    }
}
