using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Steam.Models;
using Steam.Models.DOTA2;
using Steam.Models.SteamCommunity;
using Steam.Models.SteamStore;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace MVC_Models_Exercise.Models
{
    public class SteamGame
    {
        public StoreAppDetailsDataModel Game { get; set; }
        private SteamWebInterfaceFactory webInterfaceFactory = new SteamWebInterfaceFactory("49C1D18FEEABD048FF28292E62231812");



        public SteamGame(uint id)
        {
            var gameTask = FindGame(id);
            var game = gameTask.Result;
            Game = game;
        }
        private async Task<List<FriendModel>> testAsync()
        {
            var steamInterface = webInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());
            Task.Delay(3000).Wait();
            var friendsListResponse = await steamInterface.GetFriendsListAsync(76561198203306902);
            var friendsList = friendsListResponse.Data;
            return friendsList.ToList();
        }

        private async Task<StoreAppDetailsDataModel> FindGame(uint id)
        {
            var steamInterface = webInterfaceFactory.CreateSteamStoreInterface(new HttpClient());
            Task.Delay(3000).Wait();
            var game = await steamInterface.GetStoreAppDetailsAsync(id);
            return game;
        }
    }
}
