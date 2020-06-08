using Newtonsoft.Json;

namespace SMSto.Messaging.Models.Scheduled
{
    public class ScheduledMessage
    {
        public ScheduledMessage(string message, string to)
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