using Blazored.LocalStorage;
using System.Text.Json;
using System.Threading.Tasks;
using Protocol.Type;

public class PlayerService
{
    private const string PlayerKey = "player";
    private readonly ILocalStorageService _localStorageService;
    
    public Player Player { get; set; } = new Player();

    public PlayerService(ILocalStorageService localStorageService)
    {
        _localStorageService = localStorageService;
    }
    
    public async Task ResetPlayerAsync()
    {
        Player = new Player();  // Reset to a new default Player object
        await SavePlayerAsync();
    }

    public async Task InitializePlayerAsync()
    {
        var player = await _localStorageService.GetItemAsync<Player>(PlayerKey);
        if (player != null)
        {
            Player = player;
        }
    }

    public async Task SavePlayerAsync()
    {
        await _localStorageService.SetItemAsync(PlayerKey, Player);
    }
}