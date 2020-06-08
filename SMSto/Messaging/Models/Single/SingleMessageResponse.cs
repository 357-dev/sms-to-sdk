using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Single
{
    public class SingleMessageResponse
    {
        public SingleMessageResponse(string message, bool success, string messageId)
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