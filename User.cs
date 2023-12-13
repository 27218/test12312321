class User
{
    public User(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public int Id { get; set; }
    public string name { get; set; }
}
class Program
{
    static void Main()
    {
        User ivan = new User(1,"Ivan");
        User oleg = new User(2,"Oleg");
        Console.WriteLine(ivan);
        Console.WriteLine(oleg);
        User[] users = { ivan, oleg };
        foreach (User item in users)
        {
            Console.WriteLine(item);
        }
    }
}
