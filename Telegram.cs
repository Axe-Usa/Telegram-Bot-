using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleSharp.TL;
using TLSharp;
using TLSharp.Core;
using System.IO;

namespace telegram
{
    class Program
    {
        const int apiId = 188443;
        const string apiHash = "b7f490d276e00c5fe935a0bbebacf2fa";
        const string number = "2067177907";
        const int groupId = 366353519;

        static void Main(string[] args)
        {
        	var store = new FileSessionStore();
            var client = new TelegramClient(apiId, apiHash, store);
            client.ConnectAsync();
            int i = 0;
            var hash = client.SendCodeRequestAsync(number);
            var code = "GD-9YUQfbh0"; // you can change code in debugger
            var user = client.MakeAuthAsync(number, apiHash, code);
            client.SendMessageAsync(new TLInputPeerUser() { user_id = groupId }, "TEST");
            Console.ReadKey();
            //MainAsync().Wait();
            
        }

        static async Task MainAsync()
        {
            
        }
    }
}
