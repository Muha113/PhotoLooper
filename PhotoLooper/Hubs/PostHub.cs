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
        public async Task Send(string groupname, string post)
        {
            //Console.WriteLine("\n\n\n========================================LOLOLOLOL\n\n\n");

            await Clients.Group(groupname).SendAsync("Receive", post);
        }

        public void JoinGroup(string groupId)
        {
            this.Groups.AddToGroupAsync(this.Context.ConnectionId, groupId);
            //Console.WriteLine($"\n\n\n========================================DADAYA + {groupId}\n\n\n\n\n");
        }
    }
}
