namespace Client
{

    using Core;
    using System;
    using System.ServiceModel;
    using WcfService;

    public class Program
    {

        private static NetTcpBinding binding = new NetTcpBinding();
        private static ServiceHost serviceHost = null;
        private static Uri baseAddress = new Uri("net.tcp://localhost:9901/IContract");

        public static void Main(string[] args)
        {
            // Host the Service
            HostService(baseAddress, binding);

            Console.WriteLine($"PROCESS STARTED at {DateTime.Now}");
            
            // Service <-> Client - Callback Process
            CallbackProcess();

            Console.ReadLine();
            Console.WriteLine($"PROCESS FINISHED at {DateTime.Now}");
        }

        private static void HostService(Uri baseAddress, NetTcpBinding binding)
        {
            serviceHost = new ServiceHost(typeof(MyService), baseAddress);
            serviceHost.AddServiceEndpoint(typeof(IContract), binding, "");
            serviceHost.Open();

            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.WriteLine();
        }

        private static void CallbackProcess()
        {
            var callback = new ContractCallback();
            var client = new Proxy(callback, new NetTcpBinding(), new EndpointAddress(baseAddress));

            var proxy = client.ChannelFactory.CreateChannel();
            proxy.DoSomething();
        }

    }

}