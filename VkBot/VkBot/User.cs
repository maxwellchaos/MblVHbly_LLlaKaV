using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VkBot
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
            public string bdate;

        }
    }
    public class Peer
    {
        public int id { get; set; }
        public string type { get; set; }
        public int local_id { get; set; }
    }

    public class CanWrite
    {
        public bool allowed { get; set; }
        public int reason { get; set; }
    }

    public class Conversation
    {
        public Peer peer { get; set; }
        public int in_read { get; set; }
        public int out_read { get; set; }
        public int last_message_id { get; set; }
        public int unread_count { get; set; }
        public CanWrite can_write { get; set; }
    }

    public class LastMessage
    {
        public int date { get; set; }
        public int from_id { get; set; }
        public int id { get; set; }
        public int @out { get; set; }
        public int peer_id { get; set; }
        public string text { get; set; }
        public int conversation_message_id { get; set; }
        public List<object> fwd_messages { get; set; }
        public bool important { get; set; }
        public int random_id { get; set; }
        public List<object> attachments { get; set; }
        public bool is_hidden { get; set; }
    }

    public class Item
    {
        public Conversation conversation { get; set; }
        public LastMessage last_message { get; set; }
    }

    public class Profile
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int sex { get; set; }
        public string screen_name { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public int online { get; set; }
    }

    public class Response
    {
        public int count { get; set; }
        public List<Item> items { get; set; }
        public int unread_count { get; set; }
        public List<Profile> profiles { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
    }
}
