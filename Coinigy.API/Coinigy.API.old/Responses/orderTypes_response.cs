﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Coinigy.API.Responses
{
    [JsonObject(MemberSerialization = MemberSerialization.Fields)]
    public class orderTypes_response : BaseResponse
    {
        public OrderTypes data;
        public List<object> notifications;
    }
}