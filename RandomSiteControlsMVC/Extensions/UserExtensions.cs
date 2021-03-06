﻿using System;
using Telerik.Sitefinity.Libraries.Model;
using Telerik.Sitefinity.Security.Model;
using Telerik.Sitefinity.Modules.UserProfiles;

namespace Telerik.Sitefinity.Security
{
    public static class UserExtensions
    {
        /// <summary>
        /// Returns a users avatar with fallback
        /// 🔥 From SitefinitySteve
        /// </summary>
        /// <param name="user"></param>
        /// <param name="defaultImageUrl">Set the default fallback</param>
        /// <returns>string</returns>
        public static string GetAvatar(this Telerik.Sitefinity.Security.Model.User user, string defaultImageUrl = "")
        {
            Image image;
            UserProfilesHelper.GetAvatarImageUrl(user.Id, out image);

            if (image != null)
            {
                return image.Url;
            }
            else
            {
                return (String.IsNullOrEmpty(defaultImageUrl)) ? "/SFRes/images/Telerik.Sitefinity.Resources/Images.DefaultPhoto.png" : defaultImageUrl;
            }
        }
    }
}