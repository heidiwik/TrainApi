using System;
using System.Threading.Tasks;

namespace TrainApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Station[] stationlist = await TrainApi.GetStations();

            int i = 0;
            foreach (Station station in stationlist)
            {
                i++;
                Console.WriteLine($"{i}. {station.stationName}");
            }


            Console.WriteLine("\npress any key to exit");
            Console.ReadKey(true);
        }
    }
}
