using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vk_bot
{
    public class postt
    {
        public class Size
        {
            public string src { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string type { get; set; }
        }

        public class Photo
        {
            public Size[] sizes { get; set; }
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
            public Photo photo { get; set; }
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

        public class Attachment
        {
            public string type { get; set; }
            public Doc doc { get; set; }
        }

        public class PostSource
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

        public class Item
        {
            public int id { get; set; }
            public int from_id { get; set; }
            public int owner_id { get; set; }
            public int date { get; set; }
            public int marked_as_ads { get; set; }
            public string post_type { get; set; }
            public string text { get; set; }
            public int is_pinned { get; set; }
            public Attachment[] attachments { get; set; }
            public PostSource post_source { get; set; }
            public Comments comments { get; set; }
            public Likes likes { get; set; }
            public Reposts reposts { get; set; }
            public Views views { get; set; }
            public bool is_favorite { get; set; }
        }

        public class Response
        {
            public int count { get; set; }
            public Item[] items { get; set; }
        }
        public Response response { get; set; }
    }

}
