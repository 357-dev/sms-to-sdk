using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Scheduled
{
    public class ScheduledMessageResponse
    {
        public ScheduledMessageResponse(string message, bool success)
        {
            Message = message;
            Success = success;
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("success")]
        public Boolean Success { get; }
    }
}