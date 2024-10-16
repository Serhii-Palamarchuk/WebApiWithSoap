using System.ServiceModel;

[ServiceContract]
public interface IMyService
{
    [OperationContract]
    string MySoapMethod(string input);
}
