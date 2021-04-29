using System.Collections.Generic;
using System.Runtime.Serialization;
using ApiArchitectureSample.Core.Application.SeedWork;

namespace ApiArchitectureSample.Core.Application.UseCases.User
{
    [DataContract]
    public class UsersFindAllResponse : IResponse
    {
        [DataMember(Name = "data")]
        public UsersFindAllResponseData Data { get; set; }
    }

    public class UsersFindAllResponseData
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "users")]
        public List<UsersFindAllResponseDataUser> Users { get; set; }
    }

    public class UsersFindAllResponseDataUser
    {
        [DataMember(Name = "id")]
        public int UserId { get; set; }

        [DataMember(Name = "name")]
        public string UserName { get; set; }
    }
}
