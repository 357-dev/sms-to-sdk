using Newtonsoft.Json;
using System;

namespace SMSto.Messaging.Models.Campaigns
{
    public class CampaignMessageResponse
    {
        public CampaignMessageResponse(string message, bool success, string campaignId)
        {
            Message = message;
            Success = success;
            CampaignId = campaignId;
        }

        [JsonProperty("message")]
        public string Message { get; }

        [JsonProperty("success")]
        public Boolean Success { get; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; }
    }
}