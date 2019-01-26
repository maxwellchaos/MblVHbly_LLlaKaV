using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vk_bot
{
    class User
    {
        public Response[] response;
        public class Response
        {
            public string id;
            public string first_name;
            public string last_name;
            public string photo_50;
            public string photo_100;
        }
    }
}
