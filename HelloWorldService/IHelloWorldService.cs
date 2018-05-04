
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.ServiceModel.Web;



namespace HelloWorldService
{
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        bool InsertCustomer(Customer obj);

        [OperationContract()]
        [WebGet(UriTemplate = "/GetAllCustomer", ResponseFormat = WebMessageFormat.Json)]
        List<Customer> GetAllCustomer();

        [OperationContract]
        bool DeleteCustomer(int Cid);

        [OperationContract]
        bool UpdateCustomer(Customer obj);
    }

    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerID;
        [DataMember]
        public string CustomerName;
        [DataMember]
        public string Address;
        [DataMember]
        public string EmailId;
    }
}