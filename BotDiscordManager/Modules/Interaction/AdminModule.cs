using BotDiscordManager.Core.Attributes;
using Discord;
using Discord.Interactions;
using System.Threading.Tasks;

namespace BotDiscordManager.Modules.Interaction
{
    [BotPermission(GuildPermission.Administrator)]
    [UserPermission(GuildPermission.Administrator)]
    public class AdminModule : InteractionModuleBase<SocketInteractionContext>
    {

        [SlashCommand("ping", "Test Bot")]
        public async Task HandlePingCommand()
        {
            await RespondAsync($"Pong!");
        }


        
    }
}
