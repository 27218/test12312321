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
        User alex = new User(1,"Ivan");
        User marry = new User(2,"Oleg");
        Console.WriteLine(alex);
        Console.WriteLine(marry);
        User[] users = { alex, marry };
        foreach (User item in users)
        {
            Console.WriteLine(item);
        }
    }
}