using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebApp
{
    public class EchoConnection : PersistentConnection
    {
        protected override async Task OnConnected(IRequest request, string connectionId)
        {
            //return base.OnConnected(request, connectionId);//just to make sure the code compiles fine

            await this.Connection.Send(connectionId, "Welcome, " + connectionId);//Say welcome to the new User

            // Inform other's that a new user has connected
            // Add current connectionId to exclusion list i.e do not notify the current/new user
            // return this.Connection.Broadcast("A new user is online! Let's give them a warm welcome!", connectionId);
            // return this.Connection.Broadcast("A new user is online! Let's give them a warm welcome!", new[] { connectionId });   

            var msg = new MessageType { NewUser = "Achay dost!" };
            var message = new
            {
                type = msg.NewUser,
                id = connectionId
            };

            await this.Connection.Broadcast(message);
        }



        //protected override Task OnDisconnected(IRequest request, string connectionId)
        //{

        //}

        protected override async Task OnReceived(IRequest request, string connectionId, string data)
        {
            var args = data.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (args.Length == 2 && args[0].ToLower() == "join")
            {
                await this.Groups.Add(connectionId, args[1]);
            }

            if (args.Length == 2 && args[0].ToLower() == "leave")
            {
                await this.Groups.Remove(connectionId, args[1]);
            }
        }

        private class MessageType
        {
            public string NewUser { get; set; }
        }

    }
}