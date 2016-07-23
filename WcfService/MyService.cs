namespace WcfService
{

    using Core;
    using System;
    using System.ServiceModel;

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class MyService : IContract
    {

        public void DoSomething()
        {
            // Service Action
            DateTime dateTime = DateTime.Now;
            var random = new Random();
            int value = random.Next(1, 100);
            Console.WriteLine($"Service response {dateTime} with value {value}");
            
            // Ping to the client
            var callback = OperationContext.Current.GetCallbackChannel<IContractCallback>();
            callback.OnCallback(value);
        }

    }

}