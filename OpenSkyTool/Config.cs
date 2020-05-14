using System;

namespace OpenSkyTool
{
    static class Config
    {
        // Authentication
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static string Host { get; } = "data.opensky-network.org";
        public static int Port { get; } = 2230;

        public static string WorkingDirectory { get; set; }
    }
}