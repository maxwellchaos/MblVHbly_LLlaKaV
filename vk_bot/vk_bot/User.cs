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
    public class fiendsObject
    {
        public Response response { get; set; }

        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
            public class Item
            {
                public string id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public int online { get; set; }
                public string deactivated { get; set; }
                public List<int> lists { get; set; }
            }
        }

    }








    public class RootObject
    {


        public Response response { get; set; }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
            public int unread_count { get; set; }
            public class Item
            {
               // public Conversation conversation { get; set; }
                public LastMessage last_message { get; set; }
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
            }
        }


    }


   









}
        
        
    //public class Peer2
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite2
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Photo
    //{
    //    public string photo_50 { get; set; }
    //    public string photo_100 { get; set; }
    //    public string photo_200 { get; set; }
    //}

    //public class ChatSettings2
    //{
    //    public string title { get; set; }
    //    public int members_count { get; set; }
    //    public string state { get; set; }
    //    public Photo photo { get; set; }
    //    public List<int> active_ids { get; set; }
    //}

    //public class PushSettings
    //{
    //    public bool no_sound { get; set; }
    //    public int disabled_until { get; set; }
    //    public bool disabled_forever { get; set; }
    //}

    //public class Conversation2
    //{
    //    public Peer2 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public int unread_count { get; set; }
    //    public CanWrite2 can_write { get; set; }
    //    public ChatSettings2 chat_settings { get; set; }
    //    public PushSettings push_settings { get; set; }
    //}

    //public class Sticker
    //{
    //    public int id { get; set; }
    //    public int product_id { get; set; }
    //    public string photo_64 { get; set; }
    //    public string photo_128 { get; set; }
    //    public string photo_256 { get; set; }
    //    public string photo_352 { get; set; }
    //    public string photo_512 { get; set; }
    //    public int width { get; set; }
    //    public int height { get; set; }
    //}

    //public class Attachment
    //{
    //    public string type { get; set; }
    //    public Sticker sticker { get; set; }
    //}

    //public class LastMessage2
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<Attachment> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__2
    //{
    //    public Conversation2 conversation { get; set; }
    //    public LastMessage2 last_message { get; set; }
    //}

    //public class Peer3
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite3
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation3
    //{
    //    public Peer3 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite3 can_write { get; set; }
    //}

    //public class Photo2
    //{
    //    public int pid { get; set; }
    //    public int aid { get; set; }
    //    public int owner_id { get; set; }
    //    public int user_id { get; set; }
    //    public string src { get; set; }
    //    public string src_big { get; set; }
    //    public string src_small { get; set; }
    //    public string src_xbig { get; set; }
    //    public string src_xxbig { get; set; }
    //    public int width { get; set; }
    //    public int height { get; set; }
    //    public string text { get; set; }
    //    public int created { get; set; }
    //    public string access_key { get; set; }
    //}

    //public class Attachment2
    //{
    //    public string type { get; set; }
    //    public Photo2 photo { get; set; }
    //}

    //public class LastMessage3
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<Attachment2> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__3
    //{
    //    public Conversation3 conversation { get; set; }
    //    public LastMessage3 last_message { get; set; }
    //}

    //public class Peer4
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite4
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Photo3
    //{
    //    public string photo_50 { get; set; }
    //    public string photo_100 { get; set; }
    //    public string photo_200 { get; set; }
    //}

    //public class ChatSettings3
    //{
    //    public string title { get; set; }
    //    public int members_count { get; set; }
    //    public string state { get; set; }
    //    public Photo3 photo { get; set; }
    //    public List<int> active_ids { get; set; }
    //}

    //public class PushSettings2
    //{
    //    public bool no_sound { get; set; }
    //    public int disabled_until { get; set; }
    //    public bool disabled_forever { get; set; }
    //}

    //public class Conversation4
    //{
    //    public Peer4 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite4 can_write { get; set; }
    //    public ChatSettings3 chat_settings { get; set; }
    //    public PushSettings2 push_settings { get; set; }
    //}

    //public class LastMessage4
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__4
    //{
    //    public Conversation4 conversation { get; set; }
    //    public LastMessage4 last_message { get; set; }
    //}

    //public class Peer5
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite5
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation5
    //{
    //    public Peer5 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite5 can_write { get; set; }
    //}

    //public class Video
    //{
    //    public int vid { get; set; }
    //    public int owner_id { get; set; }
    //    public string title { get; set; }
    //    public int duration { get; set; }
    //    public string description { get; set; }
    //    public int date { get; set; }
    //    public int views { get; set; }
    //    public string image { get; set; }
    //    public string image_big { get; set; }
    //    public string image_small { get; set; }
    //    public string access_key { get; set; }
    //    public string first_frame_320 { get; set; }
    //    public string first_frame_160 { get; set; }
    //    public string first_frame_130 { get; set; }
    //    public string first_frame_1280 { get; set; }
    //    public string first_frame_800 { get; set; }
    //}

    //public class Attachment3
    //{
    //    public string type { get; set; }
    //    public Video video { get; set; }
    //}

    //public class LastMessage5
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<Attachment3> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__5
    //{
    //    public Conversation5 conversation { get; set; }
    //    public LastMessage5 last_message { get; set; }
    //}

    //public class Peer6
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite6
    //{
    //    public bool allowed { get; set; }
    //}

    //public class PinnedMessage
    //{
    //    public int id { get; set; }
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> attachments { get; set; }
    //}

    //public class Photo4
    //{
    //    public string photo_50 { get; set; }
    //    public string photo_100 { get; set; }
    //    public string photo_200 { get; set; }
    //}

    //public class ChatSettings4
    //{
    //    public string title { get; set; }
    //    public PinnedMessage pinned_message { get; set; }
    //    public int members_count { get; set; }
    //    public string state { get; set; }
    //    public Photo4 photo { get; set; }
    //    public List<int> active_ids { get; set; }
    //}

    //public class PushSettings3
    //{
    //    public bool no_sound { get; set; }
    //    public int disabled_until { get; set; }
    //    public bool disabled_forever { get; set; }
    //}

    //public class Conversation6
    //{
    //    public Peer6 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite6 can_write { get; set; }
    //    public ChatSettings4 chat_settings { get; set; }
    //    public PushSettings3 push_settings { get; set; }
    //}

    //public class Doc
    //{
    //    public int did { get; set; }
    //    public int owner_id { get; set; }
    //    public string title { get; set; }
    //    public int size { get; set; }
    //    public string ext { get; set; }
    //    public string url { get; set; }
    //    public int date { get; set; }
    //    public string access_key { get; set; }
    //}

    //public class Attachment4
    //{
    //    public string type { get; set; }
    //    public Doc doc { get; set; }
    //}

    //public class LastMessage6
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<Attachment4> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__6
    //{
    //    public Conversation6 conversation { get; set; }
    //    public LastMessage6 last_message { get; set; }
    //}

    //public class Peer7
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite7
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation7
    //{
    //    public Peer7 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite7 can_write { get; set; }
    //}

    //public class LastMessage7
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__7
    //{
    //    public Conversation7 conversation { get; set; }
    //    public LastMessage7 last_message { get; set; }
    //}

    //public class Peer8
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite8
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation8
    //{
    //    public Peer8 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite8 can_write { get; set; }
    //}

    //public class LastMessage8
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__8
    //{
    //    public Conversation8 conversation { get; set; }
    //    public LastMessage8 last_message { get; set; }
    //}

    //public class Peer9
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite9
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation9
    //{
    //    public Peer9 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite9 can_write { get; set; }
    //}

    //public class LastMessage9
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__9
    //{
    //    public Conversation9 conversation { get; set; }
    //    public LastMessage9 last_message { get; set; }
    //}

    //public class Peer10
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite10
    //{
    //    public bool allowed { get; set; }
    //}

    //public class ChatSettings5
    //{
    //    public string title { get; set; }
    //    public int members_count { get; set; }
    //    public string state { get; set; }
    //    public List<int> active_ids { get; set; }
    //}

    //public class Conversation10
    //{
    //    public Peer10 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite10 can_write { get; set; }
    //    public ChatSettings5 chat_settings { get; set; }
    //}

    //public class Action
    //{
    //    public string type { get; set; }
    //    public int member_id { get; set; }
    //}

    //public class LastMessage10
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public Action action { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__10
    //{
    //    public Conversation10 conversation { get; set; }
    //    public LastMessage10 last_message { get; set; }
    //}

    //public class Peer11
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite11
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation11
    //{
    //    public Peer11 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite11 can_write { get; set; }
    //}

    //public class LastMessage11
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public int update_time { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__11
    //{
    //    public Conversation11 conversation { get; set; }
    //    public LastMessage11 last_message { get; set; }
    //}

    //public class Peer12
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite12
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation12
    //{
    //    public Peer12 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite12 can_write { get; set; }
    //}

    //public class LastMessage12
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__12
    //{
    //    public Conversation12 conversation { get; set; }
    //    public LastMessage12 last_message { get; set; }
    //}

    //public class Peer13
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite13
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Photo5
    //{
    //    public string photo_50 { get; set; }
    //    public string photo_100 { get; set; }
    //    public string photo_200 { get; set; }
    //}

    //public class ChatSettings6
    //{
    //    public string title { get; set; }
    //    public int members_count { get; set; }
    //    public string state { get; set; }
    //    public Photo5 photo { get; set; }
    //    public List<int> active_ids { get; set; }
    //}

    //public class PushSettings4
    //{
    //    public bool no_sound { get; set; }
    //    public int disabled_until { get; set; }
    //    public bool disabled_forever { get; set; }
    //}

    //public class Conversation13
    //{
    //    public Peer13 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite13 can_write { get; set; }
    //    public ChatSettings6 chat_settings { get; set; }
    //    public PushSettings4 push_settings { get; set; }
    //}

    //public class LastMessage13
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__13
    //{
    //    public Conversation13 conversation { get; set; }
    //    public LastMessage13 last_message { get; set; }
    //}

    //public class Peer14
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite14
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation14
    //{
    //    public Peer14 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite14 can_write { get; set; }
    //}

    //public class LastMessage14
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__14
    //{
    //    public Conversation14 conversation { get; set; }
    //    public LastMessage14 last_message { get; set; }
    //}

    //public class Peer15
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite15
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation15
    //{
    //    public Peer15 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite15 can_write { get; set; }
    //}

    //public class LastMessage15
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__15
    //{
    //    public Conversation15 conversation { get; set; }
    //    public LastMessage15 last_message { get; set; }
    //}

    //public class Peer16
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite16
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation16
    //{
    //    public Peer16 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite16 can_write { get; set; }
    //}

    //public class LastMessage16
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__16
    //{
    //    public Conversation16 conversation { get; set; }
    //    public LastMessage16 last_message { get; set; }
    //}

    //public class Peer17
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite17
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation17
    //{
    //    public Peer17 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite17 can_write { get; set; }
    //}

    //public class LastMessage17
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__17
    //{
    //    public Conversation17 conversation { get; set; }
    //    public LastMessage17 last_message { get; set; }
    //}

    //public class Peer18
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite18
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation18
    //{
    //    public Peer18 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite18 can_write { get; set; }
    //}

    //public class LastMessage18
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__18
    //{
    //    public Conversation18 conversation { get; set; }
    //    public LastMessage18 last_message { get; set; }
    //}

    //public class Peer19
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite19
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation19
    //{
    //    public Peer19 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite19 can_write { get; set; }
    //}

    //public class LastMessage19
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__19
    //{
    //    public Conversation19 conversation { get; set; }
    //    public LastMessage19 last_message { get; set; }
    //}

    //public class Peer20
    //{
    //    public int id { get; set; }
    //    public string type { get; set; }
    //    public int local_id { get; set; }
    //}

    //public class CanWrite20
    //{
    //    public bool allowed { get; set; }
    //}

    //public class Conversation20
    //{
    //    public Peer20 peer { get; set; }
    //    public int in_read { get; set; }
    //    public int out_read { get; set; }
    //    public int last_message_id { get; set; }
    //    public CanWrite20 can_write { get; set; }
    //}

    //public class LastMessage20
    //{
    //    public int date { get; set; }
    //    public int from_id { get; set; }
    //    public int id { get; set; }
    //    public int @out { get; set; }
    //    public int peer_id { get; set; }
    //    public string text { get; set; }
    //    public int conversation_message_id { get; set; }
    //    public List<object> fwd_messages { get; set; }
    //    public bool important { get; set; }
    //    public int random_id { get; set; }
    //    public List<object> attachments { get; set; }
    //    public bool is_hidden { get; set; }
    //}

    //public class __invalid_type__20
    //{
    //    public Conversation20 conversation { get; set; }
    //    public LastMessage20 last_message { get; set; }
    //}

    //public class Profile
    //{
    //    public int uid { get; set; }
    //    public string first_name { get; set; }
    //    public string last_name { get; set; }
    //}

    //public class Group
    //{
    //    public int gid { get; set; }
    //    public string name { get; set; }
    //    public string screen_name { get; set; }
    //    public int is_closed { get; set; }
    //    public string type { get; set; }
    //    public string photo { get; set; }
    //    public string photo_medium { get; set; }
    //    public string photo_big { get; set; }
    //}

    //public class Response
    //{
    //    public int __invalid_name__0 { get; set; }
    //    public __invalid_type__1 __invalid_name__1 { get; set; }
    //    public __invalid_type__2 __invalid_name__2 { get; set; }
    //    public __invalid_type__3 __invalid_name__3 { get; set; }
    //    public __invalid_type__4 __invalid_name__4 { get; set; }
    //    public __invalid_type__5 __invalid_name__5 { get; set; }
    //    public __invalid_type__6 __invalid_name__6 { get; set; }
    //    public __invalid_type__7 __invalid_name__7 { get; set; }
    //    public __invalid_type__8 __invalid_name__8 { get; set; }
    //    public __invalid_type__9 __invalid_name__9 { get; set; }
    //    public __invalid_type__10 __invalid_name__10 { get; set; }
    //    public __invalid_type__11 __invalid_name__11 { get; set; }
    //    public __invalid_type__12 __invalid_name__12 { get; set; }
    //    public __invalid_type__13 __invalid_name__13 { get; set; }
    //    public __invalid_type__14 __invalid_name__14 { get; set; }
    //    public __invalid_type__15 __invalid_name__15 { get; set; }
    //    public __invalid_type__16 __invalid_name__16 { get; set; }
    //    public __invalid_type__17 __invalid_name__17 { get; set; }
    //    public __invalid_type__18 __invalid_name__18 { get; set; }
    //    public __invalid_type__19 __invalid_name__19 { get; set; }
    //    public __invalid_type__20 __invalid_name__20 { get; set; }
    //    public int unread_count { get; set; }
    //    public List<Profile> profiles { get; set; }
    //    public List<Group> groups { get; set; }
    //}

    //public class RootObject
    //{
    //    public Response response { get; set; }
    //}


