using Discord.Interactions;
using Discord;
using System;
using System.Threading.Tasks;
using Discord.WebSocket;
using BotDiscordManager.Core.Bot;

namespace BotDiscordManager.Core.Services
{
    public class NotificationService
    {
        private readonly DiscordSocketClient _client;
        private readonly InteractionService _commands;

        public NotificationService(DiscordSocketClient client, InteractionService commands)
        {
            _client = client;
            _commands = commands;
        }

        public  async Task ReadyClientAsync()
        {
            await _commands.RegisterCommandsGloballyAsync();
            await _client.SetActivityAsync(new Game("BOT Quản lý , hỗ trợ những việc linh tinh ..... Code By C# Owner : GunDx(dungdzk4#8028)"));
            BotDiscord.gI().isStarted = true;
        }

        public Task ConnectedClientAsync()
        {
            Console.WriteLine($"[Connected/{_client.CurrentUser.Username}] ....");
            return Task.CompletedTask;
        }


        public Task DisconnectedClientAsync(Exception e)
        {
            BotDiscord.gI().isStarted = false;

            Console.WriteLine($"[Disconnected/{_client.CurrentUser?.Username}] {e} ....");
            return Task.CompletedTask;
        }
    }
}
