using Hypixel.NET;
using System;
using System.Text;

namespace Hyper
{
    class HyAPI
    {
        public static string ValidateAPIKey(string key, string username)
        {
            var hypixel = new HypixelApi(key, 300);
            var playerRequest = hypixel.GetUserByPlayerName(username);
            

            if (playerRequest.WasSuccessful) return playerRequest.Player.DisplayName;
            else return "An error occurred while making a request to the Hypixel Server. \nCause: " + playerRequest.Cause;
        }

    }
    public static class ExtensionMethods
    {
        public static string EncodeBase64(this string value)
        {
            var valueBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(valueBytes);
        }

        public static string DecodeBase64(this string value)
        {
            var valueBytes = System.Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(valueBytes);
        }
    }
}
