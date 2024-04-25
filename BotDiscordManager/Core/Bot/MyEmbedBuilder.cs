using Discord;

namespace BotDiscordManager.Core.Bot
{
    public class MyEmbedBuilder
    {
        public static EmbedBuilder BuildFullEmbed(EmbedAuthorBuilder author,string title, string description, string imageUrl = null, string thumbnailUrl = null, string footerText = null, string footerIconUrl = null)
        {
            var embed = new EmbedBuilder()
            .WithAuthor(author)
            .WithTitle(title)
            .WithDescription(description)
            .WithColor(Color.Blue)
            .WithCurrentTimestamp();

            if (!string.IsNullOrEmpty(imageUrl))
                embed.WithImageUrl(imageUrl);

            if (!string.IsNullOrEmpty(thumbnailUrl))
                embed.WithThumbnailUrl(thumbnailUrl);

            if (!string.IsNullOrEmpty(footerText))
            {
                if (string.IsNullOrEmpty(footerIconUrl))
                    embed.WithFooter(footerText);
                else
                    embed.WithFooter(footerText, footerIconUrl);
            }

            return embed;
        }

        public static EmbedBuilder BuildEmbedColor(Color color,EmbedAuthorBuilder author, string title, string description, string imageUrl = null, string thumbnailUrl = null, string footerText = null, string footerIconUrl = null)
        {
            var embed = new EmbedBuilder()
            .WithAuthor(author)
            .WithTitle(title)
            .WithDescription(description)
            .WithColor(color)
            .WithCurrentTimestamp();

            if (!string.IsNullOrEmpty(imageUrl))
                embed.WithImageUrl(imageUrl);

            if (!string.IsNullOrEmpty(thumbnailUrl))
                embed.WithThumbnailUrl(thumbnailUrl);

            if (!string.IsNullOrEmpty(footerText))
            {
                if (string.IsNullOrEmpty(footerIconUrl))
                    embed.WithFooter(footerText);
                else
                    embed.WithFooter(footerText, footerIconUrl);
            }

            return embed;
        }
    }
}
