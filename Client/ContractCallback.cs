namespace Client
{

    using Core;
    using System;
    using System.ServiceModel;


    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class ContractCallback : IContractCallback
    {

        public void OnCallback(int randomValue)
        {
            // Reply from the Server and Client Action
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($"Hi from client at {dateTime} with value {randomValue}");
        }

    }

}