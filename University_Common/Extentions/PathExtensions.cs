﻿
namespace University_Common.Extentions
{
    public static class PathExtensions
    {
        public static string UserAvatarOrgin = "/img/userAvatar/orgin/";
        public static string UserAvatarOrginServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/userAvatar/orgin/");

        public static string UserAvatarThumb = "/img/userAvatar/thumb/";
        public static string UserAvatarThumbServer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/userAvatar/thumb/");

    }
}
