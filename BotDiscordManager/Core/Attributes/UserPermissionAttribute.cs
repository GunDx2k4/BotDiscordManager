using Discord;
using Discord.Interactions;
using System.Threading.Tasks;
using System;
using BotDiscordManager.Core.Locales;
using BotDiscordManager.Core.Bot;

namespace BotDiscordManager.Core.Attributes
{
    public class UserPermissionAttribute : PreconditionAttribute
    {
        public GuildPermission? GuildPermission { get; }
        public ChannelPermission? ChannelPermission { get; }

        public UserPermissionAttribute(GuildPermission guildPermission)
        {
            GuildPermission = guildPermission;
        }

        public UserPermissionAttribute(ChannelPermission channelPermission)
        {
            ChannelPermission = channelPermission;
        }

        public override async Task<PreconditionResult> CheckRequirementsAsync(IInteractionContext context, ICommandInfo commandInfo, IServiceProvider services)
        {
            IGuildUser guildUser = context.User as IGuildUser;
            if (GuildPermission.HasValue)
            {
                if (guildUser == null)
                {
                    return PreconditionResult.FromError(Resources.NOT_GUILD_ERROR_MESSAGE);
                }

                if (!guildUser.GuildPermissions.Has(GuildPermission.Value))
                {
                    return PreconditionResult.FromError(ErrorMessage ?? $"{Resources.NOT_PERMISSION_USER} {UtilsBot.BoldText(UtilsBot.HighlightText(GuildPermission.Value.ToString()))}.");
                }
            }

            if (ChannelPermission.HasValue && !((!(context.Channel is IGuildChannel channel)) ? ChannelPermissions.All(context.Channel) : guildUser.GetPermissions(channel)).Has(ChannelPermission.Value))
            {
                return PreconditionResult.FromError(ErrorMessage ?? $"{Resources.USER_NOT_PERMISSION_CHANNEL}  {UtilsBot.BoldText(UtilsBot.HighlightText(ChannelPermission.Value.ToString()))}.");
            }

            return PreconditionResult.FromSuccess();
        }
    }
}
