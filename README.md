# sms-to SDK
Unofficial SMS.to SDK for C#. Focus is just on sending of SMS.

## Usage
You'll need your API key. There is no support for client id / secret.
Interface is provided for DI.

Create one of the following request objects and inject it into the service. Request / response pattern is used so each request object has the equivalent response pattern. I'm a big fan of read only objects so there are no setters :) 
* CampaignMessageRequest
* FlashMessageRequest 
* PersonalisedMessageRequest
* ScheduledMessageRequest
* SingleMessageRequest

## Example
Use DI don't integrate directly like this! 

```cs
var service = new SMStoMessageService(new HttpClient());

//var message = new SingleMessageRequest("Test", "+35799123456", "MyId");
//var message = new FlashMessageRequest("Test", "+35799123456", "MyId");
var message = new CampaignMessageRequest("Test", new string[] { "+35799123456" }, "MyId");

var response = await service.SendAsync("API_KEY_HERE", message);
Console.WriteLine(JsonConvert.SerializeObject(response));
Console.ReadLine();
```

