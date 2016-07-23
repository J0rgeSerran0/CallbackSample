namespace Core
{

    using System.ServiceModel;

    [ServiceContract]
    public interface IContractCallback
    {

        [OperationContract]
        void OnCallback(int randomValue);

    }

}
