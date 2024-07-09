using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WebUI.Hubs
{
	public class CommunicationHub : Hub
	{
		public async Task Notification(string clientId)
		{
			await Clients.All.SendAsync("Notify", clientId);
		}
	}
}
