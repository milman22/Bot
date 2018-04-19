using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace WerewolfBot
{
    class Player
    {

        private SocketGuildUser player;
        public Player(SocketGuildUser user)
        {
            player = user;
        }

        public SocketGuildUser getPlayer()
        {
            return player;
        }

        public string returnName()
        {
            return player.Username;
        }
    }
}
