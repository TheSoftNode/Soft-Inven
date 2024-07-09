using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace WebUI.Hubs;

public class SoftHubConnectionService
{
	private readonly HubConnection _hubConnection;

	public SoftHubConnectionService(NavigationManager navigationManager)
	{
		_hubConnection = new HubConnectionBuilder()
			.WithUrl(navigationManager.ToAbsoluteUri("/communicationhub"))
			.Build();

		_hubConnection.StartAsync();
	}

	public HubConnection GetHubConnection() => _hubConnection;
}
