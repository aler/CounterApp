using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Signal.Web
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public Task<string> Greeter(string name)
        {
            return Task.FromResult($"Hello {name}");
        }

        public string MyGreeter(string name)
        {
            return $"Hello sync {name}";
        }
    }

    public class CounterHub : Hub
    {
        private int _counter;

        public int GetCounter()
        {
            return _counter;
        }

        public async Task<int> IncCounter()
        {
            _counter++;
            await Clients.All.SendAsync("UpdateCounter", _counter);
            return _counter;
        }

        public string Version()
        {
            return "1.0";
        }
    }
}
