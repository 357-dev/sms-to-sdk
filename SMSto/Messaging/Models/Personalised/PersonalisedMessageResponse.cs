using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Personalised
{
    public class PersonalisedMessageResponse
    {
        public PersonalisedMessageResponse(string message, bool success)
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