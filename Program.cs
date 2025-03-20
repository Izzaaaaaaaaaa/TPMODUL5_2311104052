class HaloGeneric
{
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {data}");
    }
}
class Program
{
   
    static void Main(string[] args)
    {
        // Memanggil method generic
        HaloGeneric.SapaUser("Iza");

        //Menggunakan class generic
        DataGeneric<string> dataGeneric = new DataGeneric<string>("2311104052");
        dataGeneric.PrintData();
        Console.ReadLine();
    }
}