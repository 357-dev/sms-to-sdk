using Newtonsoft.Json;
using SMSto.Messaging.Models.Campaigns;
using SMSto.Messaging.Models.Flash;
using SMSto.Messaging.Models.Personalised;
using SMSto.Messaging.Models.Scheduled;
using SMSto.Messaging.Models.Single;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace SMSto.Messaging.Services
{
    public class SMStoMessageService : ISMStoMessageService
    {
        private const string _URL = "https://api.sms.to/sms/send";
        private const string _FLASH_URL = "https://api.sms.to/fsms/send";
        private readonly HttpClient _httpClient;

        public SMStoMessageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CampaignMessageResponse> SendAsync(string apiKey, CampaignMessageRequest request)
        {
            return JsonConvert.DeserializeObject<CampaignMessageResponse>(await ExecutePostAsync(_URL, apiKey, request));
        }

        public async Task<FlashMessageResponse> SendAsync(string apiKey, FlashMessageRequest request)
        {
            return JsonConvert.DeserializeObject<FlashMessageResponse>(await ExecutePostAsync(_FLASH_URL, apiKey, request));
        }

        public async Task<PersonalisedMessageResponse> SendAsync(string apiKey, PersonalisedMessageRequest request)
        {
            return JsonConvert.DeserializeObject<PersonalisedMessageResponse>(await ExecutePostAsync(_URL, apiKey, request));
        }

        public async Task<ScheduledMessageResponse> SendAsync(string apiKey, ScheduledMessageRequest request)
        {
            return JsonConvert.DeserializeObject<ScheduledMessageResponse>(await ExecutePostAsync(_URL, apiKey, request));
        }

        public async Task<SingleMessageResponse> SendAsync(string apiKey, SingleMessageRequest request)
        {
            return JsonConvert.DeserializeObject<SingleMessageResponse>(await ExecutePostAsync(_URL, apiKey, request));
        }

        private async Task<string> ExecutePostAsync(string url, string apiKey, object request)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, url);
            httpRequestMessage.Headers.Add("Authorization", $"Bearer {apiKey}");
            httpRequestMessage.Headers.Add("Content", MediaTypeNames.Application.Json);
            httpRequestMessage.Content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, MediaTypeNames.Application.Json);
            var response = await _httpClient.SendAsync(httpRequestMessage);

            return await response
                    .Content
                    .ReadAsStringAsync();
        }
    }
}