using Discord.Commands;
using Discord;
using System.Threading.Tasks;

namespace BotDiscordManager.Modules.Command
{
    public class AdminMoule : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task HandlePingCommand()
        {

            await Context.Message.ReplyAsync("Pong!", allowedMentions: AllowedMentions.None);
        }
    }
}
