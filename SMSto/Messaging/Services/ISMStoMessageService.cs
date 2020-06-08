using SMSto.Messaging.Models.Campaigns;
using SMSto.Messaging.Models.Flash;
using SMSto.Messaging.Models.Personalised;
using SMSto.Messaging.Models.Scheduled;
using SMSto.Messaging.Models.Single;
using System.Threading.Tasks;

namespace SMSto.Messaging.Services
{
    public interface ISMStoMessageService
    {
        Task<CampaignMessageResponse> SendAsync(string apiKey, CampaignMessageRequest request);

        Task<FlashMessageResponse> SendAsync(string apiKey, FlashMessageRequest request);

        Task<PersonalisedMessageResponse> SendAsync(string apiKey, PersonalisedMessageRequest request);

        Task<ScheduledMessageResponse> SendAsync(string apiKey, ScheduledMessageRequest request);

        Task<SingleMessageResponse> SendAsync(string apiKey, SingleMessageRequest request);
    }
}