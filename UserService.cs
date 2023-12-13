class Program
{
    static User Get(User[] users, int index) {
        return users[index];
    }
    static void Add(User[] users, User user) {
        users.Add(user);
    }
    static User[] Remove(User[] users, User user) {
        return users.Except(new User[]{user}).ToArray();
    }
    static void Main()
    {
        User ivan = new User(1,"Ivan");
        User oleg = new User(2,"Oleg");
        User[] users = { ivan, oleg };

	Console.WriteLine( Get(users, 1) );
	Remove(users, 1);
	Console.WriteLine( Get(users, 1) );
	Add(users, new User(3,"Alex"));
    }
}