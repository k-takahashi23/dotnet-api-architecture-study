using System.Runtime.Serialization;

namespace ApiArchitectureSample.PrimaryAdapters.WebApi.Models
{
    [DataContract]
    public class HelloGetByUserNameResponse
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
