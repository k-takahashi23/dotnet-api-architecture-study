using System.Runtime.Serialization;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.Hello
{
    [DataContract]
    public class HelloGetByUserNameResponse : IResponse
    {
        [DataMember(Name = "data")]
        public HelloGetByUserNameResponseData Data { get; set; }
    }

    public class HelloGetByUserNameResponseData
    {
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
