using BotDiscordManager.Core.Bot;
using Discord;
using Discord.WebSocket;
using System.Linq;
using System.Threading.Tasks;

namespace BotDiscordManager.Core.Services
{
    public class UserService
    {
        private readonly DiscordSocketClient _client;

        public UserService(DiscordSocketClient client)
        {
            _client = client;
        }

        public async Task UserLeft(SocketGuild guild,SocketUser user)
        {
            var defaultChannel = guild.SystemChannel;
            var memberEmbed = new EmbedAuthorBuilder()
            .WithName(user.GlobalName)
            .WithIconUrl(user.GetAvatarUrl());

            var embedWelcome = MyEmbedBuilder.BuildFullEmbed(memberEmbed, $"Tạm biệt bạn, cảm ơn bạn đã tham gia server.\n",
                $"⏲Tuổi của tài khoản {user.Mention}:\n{TimestampTag.FromDateTimeOffset(user.CreatedAt, TimestampTagStyles.Relative)}",
                user.GetAvatarUrl(),
                guild.IconUrl,
                $"From {guild.Name}",
                guild.IconUrl);

            await defaultChannel.SendMessageAsync(embed: embedWelcome.Build());
        }

        public async Task WelcomeNewUserAsync(SocketGuildUser newUser)
        {
            var guild = newUser.Guild;
            var defaultChannel = guild.SystemChannel;
            IRole memberRole = guild.Roles.FirstOrDefault(r => r.Name == "Member");
            if(memberRole == null)
            {
                 memberRole = await guild.CreateRoleAsync("Member", null, new Color(0x00deff), true, true);
            }
            await newUser.AddRoleAsync(memberRole.Id);

            var memberEmbed = new EmbedAuthorBuilder()
            .WithName(newUser.GlobalName)
            .WithIconUrl(newUser.GetAvatarUrl());

            var embedWelcome = MyEmbedBuilder.BuildFullEmbed(memberEmbed, $"Chào mừng bạn đã tham gia server.\n", 
                $"⏲Tuổi của tài khoản {newUser.Mention}:\n{TimestampTag.FromDateTimeOffset(newUser.CreatedAt,TimestampTagStyles.Relative)}",
                newUser.GetAvatarUrl(), 
                guild.IconUrl, 
                $"From {guild.Name}",
                guild.IconUrl);

            await defaultChannel.SendMessageAsync(embed: embedWelcome.Build());
        }

    }
}
