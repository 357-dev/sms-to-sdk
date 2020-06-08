using Newtonsoft.Json;

namespace SMSto.Messaging.Models.Personalised
{
    public class PersonalisedMessageRequest
    {
        public PersonalisedMessageRequest(PersonalisedMessage messages, string senderId = null, string callbackUrl = null)
        {
            Messages = messages;
            SenderId = senderId;
            CallbackUrl = callbackUrl;
        }

        [JsonProperty("messages")]
        public PersonalisedMessage Messages { get; }

        [JsonProperty("sender_id")]
        public string SenderId { get; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; }
    }
}