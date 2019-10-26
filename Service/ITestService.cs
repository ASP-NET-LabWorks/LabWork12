using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Subtract(int a, int b);

        [OperationContract]
        string Concatenate(string a, string b);
    }
}