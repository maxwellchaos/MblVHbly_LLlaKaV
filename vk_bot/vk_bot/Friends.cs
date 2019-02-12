using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vk_bot
{
    class Friends
    {
        public class City
        {
            public int id { get; set; }
            public string title { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool is_closed { get; set; }
            public bool can_access_closed { get; set; }
            public string domain { get; set; }
            public int online { get; set; }
            public City city { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
            public Response response { get; set; }
        
    }
}
