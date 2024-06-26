﻿using BotDiscordManager.Core.Locales;
using BotDiscordManager.Utils;
using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace BotDiscordManager.Core.Bot
{
    public class InteractionHandler
    {
        private readonly DiscordSocketClient _client;
        private readonly InteractionService _commands;
        private readonly IServiceProvider _service;

        public InteractionHandler(DiscordSocketClient client, InteractionService commands, IServiceProvider service)
        {
            _client = client;
            _commands = commands;
            _service = service;
        }

        public async Task InitializeAsync()
        {
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _service);
            _client.InteractionCreated += HandleInteraction;
            _commands.SlashCommandExecuted += SlashCommandExecuted;
        }

        async Task SlashCommandExecuted(SlashCommandInfo arg1, IInteractionContext arg2, IResult arg3)
        {
            if (!arg3.IsSuccess)
            {
                switch (arg3.Error)
                {
                    case InteractionCommandError.UnmetPrecondition:
                        await arg2.Interaction.RespondAsync($"{Resources.UNMET_PRECONDITION} {arg3.ErrorReason}");
                        break;
                    case InteractionCommandError.UnknownCommand:
                        await arg2.Interaction.RespondAsync($"{Resources.UNKNOW_COMMAND}");
                        break;
                    case InteractionCommandError.BadArgs:
                        await arg2.Interaction.RespondAsync($"{Resources.BAD_ARGS}");
                        break;
                    case InteractionCommandError.Exception:
                        await arg2.Interaction.RespondAsync($"{Resources.EXCEPTION} {arg3.ErrorReason}");
                        break;
                    case InteractionCommandError.Unsuccessful:
                        await arg2.Interaction.RespondAsync($"{Resources.UNSUCCESSFULL}");
                        break;
                    default:
                        await arg2.Interaction.RespondAsync($"{Resources.UNKNOW_ERROR} {arg3.Error}");
                        break;
                }
            }
        }


        private async Task HandleInteraction(SocketInteraction arg)
        {
            try
            {
                if (arg is SocketMessageComponent messageComponent)
                {

                }
                var ctx = new SocketInteractionContext(_client, arg);
                var result = await _commands.ExecuteCommandAsync(ctx, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Interaction/{arg.User.Username}] {ex.Message} ====> Fail in [Channel/{arg.Channel.Name}]");
                if (arg.Type == InteractionType.ApplicationCommand)
                    await arg.GetOriginalResponseAsync().ContinueWith(async (msg) => await msg.Result.DeleteAsync());
            }
        }
    }
}
