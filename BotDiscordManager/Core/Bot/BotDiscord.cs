using BotDiscordManager.Core.Locales;
using BotDiscordManager.Core.Services;
using Discord;
using Discord.Commands;
using Discord.Interactions;
using Discord.WebSocket;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BotDiscordManager.Core.Bot
{
    public class BotDiscord
    {
        private IServiceProvider services;

        public DiscordSocketClient clientBot;

        private InteractionHandler interactionHandler;

        private InteractionService interactionService;

        private CommandHandler commandHandler;

        private CommandService commandService;

        private LoggingService loggingService;

        private NotificationService notificationService;

        private UserService userService;

        private static BotDiscord bot;

        public bool isStarted;

        public BotDiscord()
        {

        }

        public static BotDiscord gI()
        {
            return bot ??= new BotDiscord();
        }

        private async void CreateBot()
        {
            clientBot = new DiscordSocketClient(new DiscordSocketConfig
            {
                AlwaysDownloadUsers = Config.DOWNLOAD_USERS,
                MessageCacheSize = Config.MESAGE_CACHE_SIZE,
                GatewayIntents = Config.GATEWAY_INTENTS
            });
            interactionService = new InteractionService(clientBot);
            interactionHandler = new InteractionHandler(clientBot, interactionService, services);

            commandService = new CommandService();
            commandHandler = new CommandHandler(clientBot, commandService, services);

            loggingService = new LoggingService(clientBot, commandService);
            notificationService = new NotificationService(clientBot, interactionService);
            userService = new UserService(clientBot);


            clientBot.Connected += notificationService.ConnectedClientAsync;
            clientBot.Disconnected += notificationService.DisconnectedClientAsync;

            clientBot.Ready += notificationService.ReadyClientAsync;

            clientBot.UserJoined += userService.WelcomeNewUserAsync;

            clientBot.UserLeft += userService.UserLeft;

            await commandHandler.InstallCommandsAsync();
            await interactionHandler.InitializeAsync();

            Vietnamese.load();
        }

        public async Task ConnectBotAsync()
        {
            if (isStarted) return;
            if (clientBot == null)
            {
                CreateBot();
            }
            await loggingService.startLog();

            await clientBot.LoginAsync(TokenType.Bot, Config.TOKEN_BOT);
            await clientBot.StartAsync();

            await Task.Delay(Timeout.Infinite);
        }


        public async Task DisconnectBotAsync()
        {
            if (!isStarted) return;
            await clientBot.StopAsync();
            clientBot = null;
        }
        
    }
}
