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
}