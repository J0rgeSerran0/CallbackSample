namespace Client
{

    using Core;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class Proxy : DuplexClientBase<IContract>
    {
        public Proxy(object callbackInstance, Binding binding, EndpointAddress remoteAddress)
            : base(callbackInstance, binding, remoteAddress) { }
    }

}