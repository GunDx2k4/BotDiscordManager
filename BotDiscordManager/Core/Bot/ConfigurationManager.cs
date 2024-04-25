using Discord;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BotDiscordManager.Core.Bot
{
    public class Config
    {
        public static char PREFIX = '!';

        public static string TOKEN_BOT = "";

        public static GatewayIntents GATEWAY_INTENTS = GatewayIntents.All;

        public static bool DOWNLOAD_USERS = true;

        public static int MESAGE_CACHE_SIZE = 1000;

        public static LogSeverity LOG_SEVERITY = LogSeverity.Debug;
    }
}
