using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Discord.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace WerewolfBot.Modules
{

    
    public class Test : ModuleBase<SocketCommandContext>
    {
        //Creates the lobby object which adds and stored people into an array
        static newLobby newLobby = new newLobby();




        //This command will display all the commands for the user
        [Command("help")]
        public async Task getHelp()
        {
            string help = ("Commands\n $help, $h - displays commands\n$play, $p - creates / enters game lobby\n$start, $s - initiates game\nI'm still in development so half these features probably dont work");
            await Context.Channel.SendMessageAsync(help);
        }
        [Command("h")]
        public async Task getHelpShortened()
        {
            string help = ("Commands\n $help, $h - displays commands\n$play, $p - creates / enters game lobby\n$start, $s - initiates game\nI'm still in development so half these features probably dont work");
            await Context.Channel.SendMessageAsync(help);

        }


        //This is just used to test private messages
        [Command("PM")]
        public async Task sendPrivateMessage(/*IGuildUser user*/)
        {
            if(Context.IsPrivate) 
            {
                await Context.Channel.SendMessageAsync("This is a PM");
            }

            else
            {
                await Context.Channel.SendMessageAsync("This is not a PM");
            }
            await Context.Channel.SendMessageAsync("you send me a message");
        }


        //This command adds people into the lobby, stores them into the player object
        [Command("addPerson")]
        public async Task addAPerson(/*IGuildUser user*/)
        {
             

            SocketGuildUser user = Context.User as SocketGuildUser;     //HENRY YOU MOTHERFUCKING GOD

            Player p1 = new Player(user);
            await Context.Channel.SendMessageAsync(newLobby.addUser(p1));
        }


        //gets size of the array AKA how many people are in the lobby
        [Command("getSize")]
        public async Task getSize()
        {

            await Context.Channel.SendMessageAsync(newLobby.returnWholeList().Count.ToString());
        }


        //Lists players in the game
        [Command("listPlayers")]
        public async Task listPlayers()
        {
            foreach(Player user in newLobby.returnWholeList())
            {
                await Context.Channel.SendMessageAsync(user.returnName());
            }
        }







    }
}















//[Command("start")]
////public async Task addpeople(IGuildUser user)
////{
////    createLobby.addPerson(user);
////    await Context.Channel.SendMessageAsync("added");
////}
//public async Task addPeople(IGuildUser user)
//{
//    Console.WriteLine("Adding user to createMatch list");
//    createLobby.addPerson(user);
//    Console.WriteLine("Added user to list");

//}
//[Command("getNewPeople")]
//public async Task newAddPeople(IUser user)
//{
//    Console.WriteLine(user);
//}

//[Command("getPeople")]
//public async Task getPeople()
//{
//    Console.WriteLine(createLobby.getList());
//    await Context.Channel.SendMessageAsync(createLobby.returnUsers());
//}

//[Command("getSize")]
//public async Task getSize()
//{
//    Console.WriteLine(createLobby.getList().Count);
//}