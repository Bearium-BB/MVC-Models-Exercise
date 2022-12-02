using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Steam.Models;
using Steam.Models.DOTA2;
using Steam.Models.SteamCommunity;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;
using System.Collections.Generic;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_Models_Exercise.Models
{
    public class SteamGame
    {
        public List<SteamAppModel> FriendsList { get; set; }
        private SteamWebInterfaceFactory webInterfaceFactory = new SteamWebInterfaceFactory("49C1D18FEEABD048FF28292E62231812");



        public SteamGame()
        {
            var eggsTask = testAsyncGame();
            List<SteamAppModel> friendModels = eggsTask.Result;
            FriendsList = friendModels;
        }
        private async Task<List<FriendModel>> testAsync()
        {
            // factory to be used to generate various web interfaces
            // this will map to the ISteamUser endpoint
            // note that you have full control over HttpClient lifecycle here
            var steamInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());
            Task.Delay(3000).Wait();
            var friendsListResponse = await steamInterface.GetFriendsListAsync(76561198203306902);
            var friendsList = friendsListResponse.Data;
            return friendsList.ToList();
        }

        private async Task<List<SteamAppModel>> testAsyncGame()
        {
            // factory to be used to generate various web interfaces
            // this will map to the ISteamUser endpoint
            // note that you have full control over HttpClient lifecycle here
            var steamInterface = webInterfaceFactory.CreateSteamWebInterface<SteamApps>(new HttpClient());
            Task.Delay(3000).Wait();
            var friendsListResponse = await steamInterface.GetAppListAsync();
            var friendsList = friendsListResponse.Data;

            return friendsList.ToList();
        }
    }
}
