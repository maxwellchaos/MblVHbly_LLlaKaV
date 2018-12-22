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

    public class Post
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



    public class Group
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



    public class Comments
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
