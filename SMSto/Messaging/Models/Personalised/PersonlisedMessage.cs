using Newtonsoft.Json;

namespace SMSto.Messaging.Models.Personalised
{
    public class PersonalisedMessage
    {
        public PersonalisedMessage(string message, string to)
        {
            Message = message;
            To = to;
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("to")]
        public string To { get; }
    }
}