using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vk_bot
{


    public class Wall
    {
        public Response response { get; set; }
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
            public int user_id { get; set; }
            public Size[] sizes { get; set; }
            public string text { get; set; }
            public int date { get; set; }
            public string access_key { get; set; }
            public int? post_id { get; set; }
        }

        public class Size2
        {
            public string src { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string type { get; set; }
        }

        public class Photo2
        {
            public Size2[] sizes { get; set; }
        }

        public class Video
        {
            public string src { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int file_size { get; set; }
        }

        public class Preview
        {
            public Photo2 photo { get; set; }
            public Video video { get; set; }
        }

        public class Doc
        {
            public int id { get; set; }
            public int owner_id { get; set; }
            public string title { get; set; }
            public int size { get; set; }
            public string ext { get; set; }
            public string url { get; set; }
            public int date { get; set; }
            public int type { get; set; }
            public Preview preview { get; set; }
            public string access_key { get; set; }
        }

        public class Video2
        {
            public int id { get; set; }
            public int owner_id { get; set; }
            public string title { get; set; }
            public int duration { get; set; }
            public string description { get; set; }
            public int date { get; set; }
            public int comments { get; set; }
            public int views { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string photo_130 { get; set; }
            public string photo_320 { get; set; }
            public string photo_800 { get; set; }
            public string photo_1280 { get; set; }
            public string access_key { get; set; }
            public string first_frame_1280 { get; set; }
            public string first_frame_800 { get; set; }
            public string first_frame_320 { get; set; }
            public string first_frame_160 { get; set; }
            public string first_frame_130 { get; set; }
            public int can_add { get; set; }
        }

        public class Attachment
        {
            public string type { get; set; }
            public Photo photo { get; set; }
            public Doc doc { get; set; }
            public Video2 video { get; set; }
        }

        public class PostSource
        {
            public string type { get; set; }
            public string platform { get; set; }
        }

        public class CopyHistory
        {
            public int id { get; set; }
            public int owner_id { get; set; }
            public int from_id { get; set; }
            public int date { get; set; }
            public string post_type { get; set; }
            public string text { get; set; }
            public Attachment[] attachments { get; set; }
            public PostSource post_source { get; set; }
        }

        public class PostSource2
        {
            public string type { get; set; }
        }

        public class Comments
        {
            public int count { get; set; }
            public int can_post { get; set; }
            public bool groups_can_post { get; set; }
        }

        public class Likes
        {
            public int count { get; set; }
            public int user_likes { get; set; }
            public int can_like { get; set; }
            public int can_publish { get; set; }
        }

        public class Reposts
        {
            public int count { get; set; }
            public int user_reposted { get; set; }
        }

        public class Views
        {
            public int count { get; set; }
        }

        public class Size3
        {
            public string type { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Photo3
        {
            public int id { get; set; }
            public int album_id { get; set; }
            public int owner_id { get; set; }
            public Size3[] sizes { get; set; }
            public string text { get; set; }
            public int date { get; set; }
        }

        public class Link
        {
            public string url { get; set; }
            public string title { get; set; }
            public string caption { get; set; }
            public string description { get; set; }
            public Photo3 photo { get; set; }
        }

        public class Video3
        {
            public int id { get; set; }
            public int owner_id { get; set; }
            public string title { get; set; }
            public int duration { get; set; }
            public string description { get; set; }
            public int date { get; set; }
            public int comments { get; set; }
            public int views { get; set; }
            public string photo_130 { get; set; }
            public string photo_320 { get; set; }
            public string photo_800 { get; set; }
            public string access_key { get; set; }
            public string platform { get; set; }
            public int can_add { get; set; }
        }

        public class Attachment2
        {
            public string type { get; set; }
            public Link link { get; set; }
            public Video3 video { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public int from_id { get; set; }
            public int owner_id { get; set; }
            public int date { get; set; }
            public string post_type { get; set; }
            public string text { get; set; }
            public CopyHistory[] copy_history { get; set; }
            public int is_pinned { get; set; }
            public PostSource2 post_source { get; set; }
            public Comments comments { get; set; }
            public Likes likes { get; set; }
            public Reposts reposts { get; set; }
            public Views views { get; set; }
            public Attachment[] attachments { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
        }
    }

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

    public class groups
    {
        public Response response { get; set; }
        
        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
            public string screen_name { get; set; }
            public int is_closed { get; set; }
            public string type { get; set; }

            public string photo_50 { get; set; }
            public string photo_100 { get; set; }
            public string photo_200 { get; set; }

        }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
        }
    }


    public class groupsGet
    {
        public Response response { get; set; }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
        }
        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
            public string screen_name { get; set; }
            public int is_closed { get; set; }
            public string type { get; set; }

            public string photo_50 { get; set; }
            public string photo_100 { get; set; }
            public string photo_200 { get; set; }

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

    public class PostR
    {
        public Response response { get; set; }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
            public Views views { get; set; }
            public Reposts reposts { get; set; }
            public Likes likes { get; set; }
            public Comments comments { get; set; }
            public PostSource postsource { get; set; }
            public Attachment attachment { get; set; }
            public Photo photo { get; set; }
            public Size size { get; set; }

            public class Item
            {
                public int id { get; set; }
                public int from_id { get; set; }
                public int owner_id { get; set; }
                public int date { get; set; }
                public int marked_as_ads { get; set; }
                public int is_pinned { get; set; }
                public string post_type { get; set; }
                public string text { get; set; }
                public Attachment[] attachments { get; set; }
                public PostSource post_source { get; set; }
                public Comments comments { get; set; }
                public Likes likes { get; set; }
                public Reposts reposts { get; set; }
                public Views views { get; set; }
            }

            public class Views
            {
                public int count { get; set; }
            }

            public class Reposts
            {
                public int count { get; set; }
                public int user_reposted { get; set; }
            }

            public class Likes
            {
                public int count { get; set; }
                public int user_likes { get; set; }
                public int can_like { get; set; }
                public int can_publish { get; set; }
            }

            public class Comments
            {
                public int count { get; set; }
                public int can_post { get; set; }
                public bool groups_can_post { get; set; }
            }

            public class PostSource
            {
                public string type { get; set; }
            }

            public class Attachment
            {
                public string type { get; set; }
                public Photo photo { get; set; }
            }

            public class Photo
            {
                public int id { get; set; }
                public int album_id { get; set; }
                public int owner_id { get; set; }
                public int user_id { get; set; }
                public Size[] sizes { get; set; }
                public string text { get; set; }
                public int date { get; set; }
                public int post_id { get; set; }
                public string access_key { get; set; }
            }

            public class Size
            {
                public string type { get; set; }
                public string url { get; set; }
                public int width { get; set; }
                public int height { get; set; }
            }
        }
    }



    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public string type { get; set; }
        public int is_admin { get; set; }
        public int is_member { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public string photo_200 { get; set; }
    }



    public class Group//
    {
        public Response response { get; set; }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }

            public class Item
            {
                public int id { get; set; }
                public string name { get; set; }
                public string screen_name { get; set; }
                public int is_closed { get; set; }
                public string type { get; set; }
                public int is_admin { get; set; }
                public int is_member { get; set; }
                public string photo_50 { get; set; }
                public string photo_100 { get; set; }
                public string photo_200 { get; set; }
            }
        }
    }



    public class Comments//
    {
        public Response response { get; set; }
        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
            public Profile[] profiles { get; set; }
            public object[] groups { get; set; }
            public int current_level_count { get; set; }
            public bool can_post { get; set; }
            public bool show_reply_button { get; set; }
            public bool groups_can_post { get; set; }
            public class Thread
            {
                public int count { get; set; }
                public object[] items { get; set; }
                public bool can_post { get; set; }
                public bool show_reply_button { get; set; }
                public bool groups_can_post { get; set; }
            }

            public class Item
            {
                public int id { get; set; }
                public int from_id { get; set; }
                public int can_edit { get; set; }
                public int post_id { get; set; }
                public int owner_id { get; set; }
                public object[] parents_stack { get; set; }
                public int date { get; set; }
                public string text { get; set; }
                public Thread thread { get; set; }
            }

            public class Profile
            {
                public int id { get; set; }
                public string first_name { get; set; }
                public string last_name { get; set; }
                public bool is_closed { get; set; }
                public bool can_access_closed { get; set; }
                public int sex { get; set; }
                public string screen_name { get; set; }
                public string photo_50 { get; set; }
                public string photo_100 { get; set; }
                public int online { get; set; }
            }
        }
    }

}
