using System.Runtime.Serialization;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    [DataContract]
    public class UsersGetByIdResponse : IResponse
    {
        [DataMember(Name = "data")]
        public UsersGetByIdResponseData Data { get; set; }
    }

    public class UsersGetByIdResponseData
    {
        [DataMember(Name = "user")]
        public string UserName { get; set; }

        [DataMember(Name = "address")]
        public UsersGetByIdResponseDataAddress Address { get; set; }
    }

    public class UsersGetByIdResponseDataAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
