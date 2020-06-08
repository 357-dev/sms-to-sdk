using Newtonsoft.Json;

namespace SMSto.Messaging.Models.Flash
{
    public class FlashMessageRequest
    {
        public FlashMessageRequest(string message, string to, string senderId = null, string callbackUrl = null)
        {
            Message = message;
            To = to;
            SenderId = senderId;
            CallbackUrl = callbackUrl;
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("to")]
        public string To { get; }

        [JsonProperty("sender_id")]
        public string SenderId { get; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; }
    }
}