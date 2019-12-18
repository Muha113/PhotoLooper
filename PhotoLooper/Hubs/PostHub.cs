using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using PhotoLooper.Models;

namespace PhotoLooper.Hubs
{
    public class PostHub : Hub
    {
        public async Task Send(string post)
        {
            await Clients.All.SendAsync("Send", post);
        }
    }
}
