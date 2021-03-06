﻿using CommandLine;

namespace Server
{
    public class Options
    {
        [Option("id", Required = false, Default = 1)]
        public int Id { get; set; }

        [Option("config", Required = false, Default = "AllServer.txt")]
        public string Config { get; set; }
    }
}
