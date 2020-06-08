using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Flash
{
    public class FlashMessageResponse
    {
        public FlashMessageResponse(string message, bool success, string messageId)
        {
            Message = message;
            Success = success;
            MessageId = messageId;
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("success")]
        public Boolean Success { get; }

        [JsonProperty("message_id")]
        public string MessageId { get; }
    }
}