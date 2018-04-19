using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace WerewolfBot
{
    class CreateLobby
    {
        List<IGuildUser> players = new List<IGuildUser>();
        
        public CreateLobby()
        {

            
        }
        public List<IGuildUser> returnWholeList()
        {
            return players;
        }
        public void addPerson(IGuildUser user)
        {
            players.Add(user);

        }
        
        public string checkIfDuplicate(IGuildUser user)
        {
            string returnString = "";
            if(players.Contains(user))
            {
                returnString = "User is already in the lobby!";
            }
            else
            {
                addPerson(user);
                returnString = "Added User";
            }

            return returnString;
        }
        

    }
}
