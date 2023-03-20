

using KolayCAR.Broker.Infrastructure.Helpers;
using Newtonsoft.Json;
using static ConsoleApp1.deneme;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (s != "")
            {
                Console.WriteLine("\n\n\n\n");
                var e = JsonConvert.DeserializeObject<ReservationToken>(EncryptionHelper.DecryptAES256(s));

                Console.WriteLine(e.ToString().Replace(",", "\n"));
                Console.ReadLine();
            }
          
        }
    }

}