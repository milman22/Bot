using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace WerewolfBot
{
    class Program
    {
        static void Main(string[] args)
        => new Program().StartAsync().GetAwaiter().GetResult();
        

        private DiscordSocketClient client;
        private CommandHandler handler;

        public CreateLobby createLobby = new CreateLobby();
        public async Task StartAsync()
        {


            
            client = new DiscordSocketClient();
            handler = new CommandHandler(client);
            await client.LoginAsync(TokenType.Bot, "NDMzNTQ1NjY0MTQwNTQxOTY1.Da9lLw.syn1iW46EtuGr3M-yBPKtawEQO0");

            await client.StartAsync();

            await Task.Delay(-1);

            
        }

        //public CreateLobby lobby()
        //{
        //    return createLobby;
        //}
    }
}
