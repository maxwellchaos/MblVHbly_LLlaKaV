using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vk_bot
{
    class xxxx
    {
        
        }

        public class UnreadMessages
        {
            public Response response { get; set; }

            public class Peer
        {
            public int id { get; set; }
            public string type { get; set; }
            public int local_id { get; set; }
        }

        public class CanWrite
        {
            public bool allowed { get; set; }
            public int? reason { get; set; }
        }

        public class Size
        {
            public string type { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Photo
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public Size[] sizes { get; set; }
            public string text { get; set; }
            public int date { get; set; }
            public string access_key { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Photo photo { get; set; }
        }

        public class PinnedMessage
        {
            public int id { get; set; }
            public int date { get; set; }
            public int from_id { get; set; }
            public int peer_id { get; set; }
            public string text { get; set; }
            public int conversation_message_id { get; set; }
            public object[] fwd_messages { get; set; }
            public Attachment[] attachments { get; set; }
        }

        public class Photo2
        {
            public string photo_50 { get; set; }
            public string photo_100 { get; set; }
            public string photo_200 { get; set; }
        }

        public class Acl
        {
            public bool can_invite { get; set; }
            public bool can_change_info { get; set; }
            public bool can_change_pin { get; set; }
            public bool can_promote_users { get; set; }
            public bool can_see_invite_link { get; set; }
            public bool can_change_invite_link { get; set; }
        }

        public class ChatSettings
        {
            public string title { get; set; }
            public PinnedMessage pinned_message { get; set; }
            public int members_count { get; set; }
            public string state { get; set; }
            public Photo2 photo { get; set; }
            public int[] active_ids { get; set; }
            public Acl acl { get; set; }
            public bool is_group_channel { get; set; }
            public int owner_id { get; set; }
        }

        public class PushSettings
        {
            public bool no_sound { get; set; }
            public int disabled_until { get; set; }
            public bool disabled_forever { get; set; }
        }

        public class Conversation
        {
            public Peer peer { get; set; }
            public int in_read { get; set; }
            public int out_read { get; set; }
            public int last_message_id { get; set; }
            public int unread_count { get; set; }
            public CanWrite can_write { get; set; }
            public ChatSettings chat_settings { get; set; }
            public PushSettings push_settings { get; set; }
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
            public object[] fwd_messages { get; set; }
            public bool important { get; set; }
            public int random_id { get; set; }
            public object[] attachments { get; set; }
            public bool is_hidden { get; set; }
        }

        public class Item
        {
            public Conversation conversation { get; set; }
            public LastMessage last_message { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
            public int unread_count { get; set; }
        }
    }
}
