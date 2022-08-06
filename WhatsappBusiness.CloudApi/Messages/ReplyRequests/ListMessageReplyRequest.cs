﻿using Newtonsoft.Json;
using WhatsappBusiness.CloudApi.Messages.Requests;

namespace WhatsappBusiness.CloudApi.Messages.ReplyRequests
{
    public class ListMessageReplyRequest : InteractiveListMessageRequest
    {
        [JsonProperty("context")]
        public ListMessageContext Context { get; set; }
    }

    public class ListMessageContext
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}
