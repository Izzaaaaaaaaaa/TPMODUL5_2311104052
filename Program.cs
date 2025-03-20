class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class Program
{
   
    static void Main(string[] args)
    {
        // Memanggil method generic
        HaloGeneric.SapaUser("Iza");

    }
}