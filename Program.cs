using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("SmartPhone Nokia: ");
        Smartphone nokia = new Nokia("1234", "Modelo 1", "1111111", 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("whatsapp");

        Console.WriteLine("--------------------");


        Console.WriteLine("SmartPhone Iphone: ");
        Smartphone Iphone = new Iphone("4002", "Modelo XIS", "22222222", 128);
        nokia.Ligar();
        nokia.InstalarAplicativo("Telegram");

        
    }
}