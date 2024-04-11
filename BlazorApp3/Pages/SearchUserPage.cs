using BlazorApp3.Common.Manager;
using BlazorApp3.Common.Type;
using Enum;

namespace BlazorApp3.Pages;

public partial class SearchUserPage
{
    public string searchedNickName= string.Empty;

    public UserInfo userInfo;
    public string nickNameBeforeEdit = string.Empty;
    string nickNameToAdd = string.Empty;
    bool dialogIsOpen = false;
    
    List<UserWinRateHistory> userWinRateHistories = new List<UserWinRateHistory>();
    
    UserWinRateHistory topWinRateHistory = new UserWinRateHistory();
    UserWinRateHistory jgWinRateHistory = new UserWinRateHistory();
    UserWinRateHistory midWinRateHistory = new UserWinRateHistory();
    UserWinRateHistory adcWinRateHistory = new UserWinRateHistory();
    UserWinRateHistory supWinRateHistory = new UserWinRateHistory();

    private void Reset()
    {
        topWinRateHistory = new UserWinRateHistory();
        jgWinRateHistory = new UserWinRateHistory();
        midWinRateHistory = new UserWinRateHistory();
        adcWinRateHistory = new UserWinRateHistory();
        supWinRateHistory = new UserWinRateHistory();
        
        nickNameBeforeEdit = string.Empty;
    }
    
    private async Task SearchUserAsync()
    {
        Reset();
        userInfo = await UserManager.GetUserAsync(searchedNickName);
        
        if(userInfo == null)
        {
            return;
        }

        nickNameBeforeEdit = userInfo.UserName;
        var userWinRateHistories = (await RankManager.GetUserWinRateHistory(userInfo.Seq)).UserWinRateHistory;

        topWinRateHistory = userWinRateHistories.First(e => e.LineType == (int) LineType.Top);
        jgWinRateHistory = userWinRateHistories.First(e => e.LineType == (int) LineType.Jungle);
        midWinRateHistory = userWinRateHistories.First(e => e.LineType == (int) LineType.Mid);
        adcWinRateHistory = userWinRateHistories.First(e => e.LineType == (int) LineType.Adc);
        supWinRateHistory = userWinRateHistories.First(e => e.LineType == (int) LineType.Support);
    }

    private async Task AddNewUserBtnAsync()
    {
        var user = await UserManager.GetUserAsync(nickNameToAdd);
        if (user != null)
        {
            return;
        }

        await UserManager.SetNewUserAsync(nickNameToAdd);
        nickNameToAdd = string.Empty;
        CloseDialog();
    }

    private async Task EditUserAsync()
    {
        List<UserWinRateHistory> list = new List<UserWinRateHistory>()
        {
            topWinRateHistory, jgWinRateHistory, midWinRateHistory, adcWinRateHistory, supWinRateHistory
        };

        await RankManager.SetUserWinRateHistory(list, userInfo.Seq, userInfo.UserName);

        if (userInfo.UserName != nickNameBeforeEdit)
        {
            var isDuplicatedNickName = await UserManager.SetUserNickNameAsync(userInfo);

            if (!isDuplicatedNickName)
            {
                nickNameBeforeEdit = userInfo.UserName;
            }
        }
    }
    
    private void OpenDialog()
    {
        dialogIsOpen = true;
    }
    
    private void CloseDialog()
    {
        dialogIsOpen = false;
    }
}