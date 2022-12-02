using MVC_Models_Exercise.Models;
using Steam.Models;
using Steam.Models.SteamCommunity;
using Steam.Models.SteamStore;
using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;

namespace MVC_Models_Exercise.Models
{
    public class SteamGameRepository
    {

        public List<SteamGame> Games { get; set; } = new List<SteamGame>();
        private SteamWebInterfaceFactory webInterfaceFactory = new SteamWebInterfaceFactory("49C1D18FEEABD048FF28292E62231812");
        private UInt32[] appId = { 346110, 314650, 294100, 674940, 219740, 4000, 602960, 1245620 };


        public SteamGameRepository()
        {
            foreach (var id in appId)
            {
                SteamGame sg = new SteamGame(id);
                if (sg != null)
                    Games.Add(sg);
            }
        }
    }
}
//public List<SteamGame> Games { get; set; } = new List<SteamGame>();
//private SteamWebInterfaceFactory webInterfaceFactory = new SteamWebInterfaceFactory("49C1D18FEEABD048FF28292E62231812");
//private UInt32[] appId = { 346110 };


//public SteamGameRepository()
//{
//    foreach (var id in appId)
//    {
//        SteamGame sg = new SteamGame(id);
//        if (sg != null)
//            Games.Add(sg);
//    }
//}
