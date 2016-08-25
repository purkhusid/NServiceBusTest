using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Samples.StepByStep.Server";
            var busConfiguration = new BusConfiguration();
            busConfiguration.EndpointName("Samples.StepByStep.Server");
            busConfiguration.UseSerialization<JsonSerializer>();
            busConfiguration.EnableInstallers();
            busConfiguration.UsePersistence<InMemoryPersistence>();

            using (var bus = Bus.Create(busConfiguration).Start())
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
