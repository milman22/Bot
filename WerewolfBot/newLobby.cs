using System;
using System.Collections.Generic;
using System.Text;

namespace WerewolfBot
{
    class newLobby
    {
        private List<Player> listOfPlayers = new List<Player>();
        public newLobby()
        {

        }

        public List<Player> returnWholeList()
        {
            return listOfPlayers;
        }

        public string addUser(Player user)
        {

            if(listOfPlayers.Contains(user))
            {
                return "This player is already in!";
            }

            else
            {
                listOfPlayers.Add(user);
                
            }
            string returnString = "The following people are in game:\n";
            foreach (Player player in listOfPlayers)
            {
                returnString += player.returnName() + "\n";
            }

            return returnString;

        }
    }
}
