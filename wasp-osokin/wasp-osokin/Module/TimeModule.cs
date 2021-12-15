using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace wasp_osokin.Module
{
    public class TimeModule : ModuleBase<SocketCommandContext>
    {
        [Command("time")]
        public Task Time()
        {
            return ReplyAsync(Context.Message.ToString());
        }
    }
}