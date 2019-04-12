using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;

namespace ClockAlertBot
{
    class Program
    {
        static DiscordClient discord;
        static DiscordChannel channel;
        static VoiceStateUpdateEventArgs voice;
        static void Main(string[] args)
        {
            MainAsync(args).ConfigureAwait(false).GetAwaiter().GetResult();
        }
        static async Task MainAsync(string[] args)
        {
            discord = new DiscordClient(new DiscordConfiguration
            {
                Token = "[Insert Your Bot's Token Here]",
                TokenType = TokenType.Bot,
                UseInternalLogHandler = true,
                LogLevel = LogLevel.Debug
            });

            channel = await discord.GetChannelAsync("[Insert Your Discord Channel's Number Here]");
            var t = new System.Threading.Timer(async o => await CheckTimerAsync(), null, 0, 10000);
            discord.MessageCreated += TimeCheckAsync;

            await discord.ConnectAsync();
            await Task.Delay(-1);
        }

        static async Task TimeCheckAsync(MessageCreateEventArgs e)
        {
            DateTime localDate = DateTime.Now;
            string hour_time = string.Format("{0:hh:mm tt}", localDate);
            if (e.Message.Content.ToLower().StartsWith("time"))
                await e.Message.RespondAsync($"The time is `{string.Format("{0:hh:mm tt}", localDate)}`");
        }

        static async Task CheckTimerAsync()
        {
            DateTime localDate = DateTime.Now;
            string hour_time = string.Format("{0:hh:mm tt}", localDate);
            switch (hour_time)
            {
                case "12:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 12:00 AM.", true);
                    break;
                case "01:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 01:00 AM.", true);
                    break;
                case "02:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 02:00 AM", true);
                    break;
                case "03:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 03:00 AM", true);
                    break;
                case "04:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 04:00 AM", true);
                    break;
                case "05:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 05:00 AM", true);
                    break;
                case "06:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 06:00 AM", true);
                    break;
                case "07:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 07:00 AM", true);
                    break;
                case "08:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 08:00 AM", true);
                    break;
                case "09:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 09:00 AM", true);
                    break;
                case "10:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 10:00 AM", true);
                    break;
                case "11:00 AM":
                    await discord.SendMessageAsync(channel, "It is currently 11:00 AM", true);
                    break;
                case "12:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 12:00 PM", true);
                    break;
                case "01:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 01:00 PM", true);
                    break;
                case "02:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 02:00 PM", true);
                    break;
                case "03:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 03:00 PM", true);
                    break;
                case "04:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 04:00 PM", true);
                    break;
                case "05:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 05:00 PM", true);
                    break;
                case "06:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 06:00 PM", true);
                    break;
                case "07:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 07:00 PM", true);
                    break;
                case "08:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 08:00 PM", true);
                    break;
                case "09:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 09:00 PM", true);
                    break;
                case "10:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 10:00 PM", true);
                    break;
                case "11:00 PM":
                    await discord.SendMessageAsync(channel, "It is currently 11:00 PM.", true);
                    break;
            }
        }
    }
}
