﻿namespace OAuth2Server.App.Authorization.UI.Logout
{
    public class LoggedOutViewModel
    {
        public string PostLogoutRedirectUri { get; set; }
        public string ClientName { get; set; }
        public string SignOutIframeUrl { get; set; }
    }
}