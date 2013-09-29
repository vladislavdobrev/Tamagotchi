using System.Runtime.Serialization;

namespace Tamagotchi.WebApi.Models
{
    [DataContract]
    public class LoggedUserModel
    {
        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "sessionKey")]
        public string SessionKey { get; set; }
    }
}