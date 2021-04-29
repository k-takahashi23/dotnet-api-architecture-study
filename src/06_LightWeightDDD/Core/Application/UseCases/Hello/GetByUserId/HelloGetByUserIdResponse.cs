using System.Runtime.Serialization;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    [DataContract]
    public class HelloGetByUserIdResponse : IResponse
    {
        [DataMember(Name = "data")]
        public HelloGetByUserIdResponseData Data { get; set; }
    }

    public class HelloGetByUserIdResponseData
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
