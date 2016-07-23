# CallbackSample
WCF Callback Sample written in C#

## Description
This is a demo/project to show you how a WCF callback App works.

In some scenarios is useful call a WCF service and get a response from it, for example:
- To know if the service is alive.
- Get a response from the service to know if the call has been received.
- Etc...

The solution that you can find here has three projects:
* **Core**: Here you will fine the contracts.
* **WcfService**: The service that process an action (whatever) and returns a value to the client or consumer.
* **Client**: Here we host the service, execute a call to the service and get the response (callback) with the value returned from the service.

Happy coding!
