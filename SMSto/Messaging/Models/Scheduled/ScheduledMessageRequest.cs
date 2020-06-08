using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Scheduled
{
    public class ScheduledMessageRequest
    {
        public ScheduledMessageRequest(ScheduledMessage messages, DateTime scheduledFor, TimeZoneInfo timezone, string senderId = null, string callbackUrl = null)
        {
            Messages = messages;
            ScheduledFor = scheduledFor;
            Timezone = timezone;
            SenderId = senderId;
            CallbackUrl = callbackUrl;
        }

        [JsonProperty("messages")]
        public ScheduledMessage Messages { get; }

        [JsonProperty("scheduled_for")]
        public DateTime ScheduledFor { get; }

        [JsonProperty("timezone")]
        public TimeZoneInfo Timezone { get; }

        [JsonProperty("sender_id")]
        public string SenderId { get; }

        [JsonProperty("callback_url")]
        public string CallbackUrl { get; }
    }
}