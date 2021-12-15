using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace wasp_osokin.Module
{
    public class ConnectModule : ModuleBase<SocketCommandContext>
    {
        [Command("connect")]
        public Task Connect()
        {
            return ReplyAsync($"С подключением, {Context.Message.Author.Username}#{Context.Message.Author.Id}");
        }
    }
}
