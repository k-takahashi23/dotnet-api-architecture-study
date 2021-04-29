using System.Runtime.Serialization;

namespace ApiArchitectureSample.PrimaryAdapters.WebApi.Models
{
    [DataContract]
    public class HelloGetByUserIdResponse
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
