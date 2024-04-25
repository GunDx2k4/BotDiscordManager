using Discord;
using System.Threading.Tasks;
using System;
using Discord.Commands;
using System.Linq;
using Discord.WebSocket;

namespace BotDiscordManager.Core.Services
{
    public class LoggingService
    {
        private readonly DiscordSocketClient _client;
        private readonly CommandService _commands;

        public LoggingService(DiscordSocketClient client, CommandService command)
        {
            _client = client;
            _commands = command;
        }


        public Task startLog()
        {
            _client.Log += LogAsync;

            _commands.Log += LogAsync;

            return Task.CompletedTask;
        }

        private Task LogAsync(LogMessage message)
        {
            if (message.Exception is CommandException cmdException)
            {
                Logger.Debug($"[Command/{message.Severity}] {cmdException.Command.Aliases.First()}"
                    + $" failed to execute in {cmdException.Context.Channel}.");
                Logger.Info($"{cmdException}");
            }
            else
            {
                Logger.Debug($"[General/{message.Severity}] {message}");
            }
            return Task.CompletedTask;
        }
    }
}
