using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Counter.Web
{
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
