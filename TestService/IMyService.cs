using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();

        [OperationContract]
        string GetMessage(string Name);
        [OperationContract]
        string GetResult(Student S);
        [OperationContract]
        int GetMax(int[] ar);
        [OperationContract]
        int[] GetSorted(int[] ar);
        [OperationContract]
        List<Country> GetAllCountries();
    }
}
