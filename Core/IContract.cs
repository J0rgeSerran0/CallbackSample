namespace Core
{

    using System.ServiceModel;

    [ServiceContract(CallbackContract = typeof(IContractCallback))]
    public interface IContract
    {

        [OperationContract(IsOneWay = true)]
        void DoSomething();

    }

}
