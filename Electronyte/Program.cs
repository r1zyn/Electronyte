using System;

namespace Electronyte
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronyteClient client = new ElectronyteClient();
            client.RunAsync().GetAwaiter().GetResult();
        }
    }
}
