using System;

namespace Final022
{
    class Program
    {
        static void Main(string[] args)
        {
			var person = new Target();
			person.name = "Jack";

			var alarm = new Custom();
			alarm.UserNameEvent += person.CheckUsernameAlarm;

			alarm.CheckUserName(person.name);
		}
    }
}


public class Target
{
	public string name { get; set; }

	public void CheckUsernameAlarm(object sender, CustomEventArgs e)
	{
		if(name == "Jack")
			Console.WriteLine(" {0} is not allow", e.userName);
	}

}


public class Custom
{
	public event CustomEventHandeler UserNameEvent;

	public void CheckUserName(string userName)
	{
		CustomEventHandeler alarm = UserNameEvent;
		if (UserNameEvent != null)
		{
			alarm(this, new CustomEventArgs(userName));
		}

	}
}

public delegate void CustomEventHandeler(object source, CustomEventArgs e);
	
public class CustomEventArgs : EventArgs
{
	public string userName { get; set; }

	public CustomEventArgs(string userName)
    {
		this.userName = userName;
    }
}
