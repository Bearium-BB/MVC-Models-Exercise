using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Models_Exercise.Models
{
    internal class VideoGameRepository
    {
        public HashSet<VideoGame> VideoGames { get; set; } = new();
        public HashSet<VideoGameConsole> Consoles { get; set; } = new();
        public HashSet<Publisher> Publishers { get; set; } = new();
        public HashSet<Studio> Studios { get; set; } = new();

        public VideoGameRepository()
        {
            Studio WildcardStudio = new("Wildcard Studio", 4_000_000);
            Studios.Add(WildcardStudio);

            Publisher WildcardPublishing = new("Wildcard Publishing", 4_000_000);
            Publishers.Add(WildcardPublishing);

            Studio coffeeStainStudio = new("Coffee Stain Studios", 1_000_000);
            Studio maddyMakesGamesStudio = new("Maddy Makes Games", 3_000_000);

            Studios.Add(maddyMakesGamesStudio);
            Studio monolithSoft = new("Monolith Soft", 1_000_000);
            Studio halLabs = new("HAL Laboratories", 1_000_000);

            Studios.Add(coffeeStainStudio);
            Studios.Add(monolithSoft);
            Studios.Add(halLabs);

            Publisher coffeeStainPublishing = new("Coffee Stain Publishing", 1_000_000);

            Publisher maddyMakesGamesPublishing = new("Maddy Makes Games", 36_000_000);
            Publishers.Add(coffeeStainPublishing);
            Publishers.Add(maddyMakesGamesPublishing);

            Publisher nintendo = new("Nintendo", 100_000_000);
            Publishers.Add(nintendo);

            Studio KeenSoftwareHouseStudio = new("Keen Software House Studios", 500_000);
            Studios.Add(KeenSoftwareHouseStudio);

            Publisher KeenSoftwareHousePublishing = new("Keen Software House Publishing", 500_000);
            Publishers.Add(KeenSoftwareHousePublishing);

            Publisher NamcoBandai = new("Namco Bandai", 571_000_000);
            Publishers.Add(NamcoBandai);

            VideoGameConsole pc = new("PC", 1500, 20, true);
            VideoGameConsole wiiU = new("Wii U", 400, 8, true);
            VideoGameConsole nSwitch = new("Switch", 400, 8, true);

            Consoles.Add(pc);
            Consoles.Add(wiiU);
            Consoles.Add(nSwitch);

            VideoGame satisfactory = new(
                title: "Satisfactory",
                category: "Simulation",
                year: 2018,
                playerCount: 4,
                price: 40f,
                studio: coffeeStainStudio,
                consoles: new() { pc },
                publisher: coffeeStainPublishing,
                ageRating: 10

                );

            VideoGame celeste = new(
                title: "Celeste",
                category: "Platformer",
                year: 2018,
                playerCount: 1,
                price: 20f,
                studio: maddyMakesGamesStudio,
                consoles: new() { pc },
                publisher: maddyMakesGamesPublishing,
                ageRating: 10
                );

            VideoGames.Add(satisfactory);
            VideoGames.Add(celeste);

            coffeeStainStudio.AddGame(satisfactory);
            coffeeStainPublishing.AddStudio(coffeeStainStudio);

            VideoGame ARKSurvivalEvolved = new(
                title: "ARK: Survival Evolved",
                category: "Survival",
                year: 2017,
                playerCount: 100,
                price: 20f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            VideoGames.Add(ARKSurvivalEvolved);
            WildcardStudio.AddGame(ARKSurvivalEvolved);
            WildcardPublishing.AddStudio(WildcardStudio);
            pc.AddGame(ARKSurvivalEvolved);

            VideoGame SpaceEngineers = new(
                title: "Space Engineers",
                category: "Survival",
                year: 2019,
                playerCount: 20,
                price: 22f,
                studio: WildcardStudio,
                consoles: new() { pc },
                publisher: WildcardPublishing,
                ageRating: 13
                );
            VideoGames.Add(SpaceEngineers);
            WildcardStudio.AddGame(SpaceEngineers);
            coffeeStainStudio.AddGame(SpaceEngineers);
            pc.AddGame(SpaceEngineers);

            Studio hopooGames = new("Hopoo Games", 5_000_000);
            Studios.Add(hopooGames);

            Publisher gearbox = new("Gearbox", 5);
            Publishers.Add(gearbox);

            VideoGame riskOfRain = new(
                title: "Risk of Rain",
                category: "Roguelike",
                year: 2013,
                playerCount: 4,
                price: 11f,
                studio: hopooGames,
                consoles: new() { pc, nSwitch },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain);

            hopooGames.AddGame(riskOfRain);
            gearbox.AddStudio(hopooGames);
            pc.AddGame(riskOfRain);
            nSwitch.AddGame(riskOfRain);

            VideoGame riskOfRain2 = new(
                title: "Risk of Rain 2",
                category: "Roguelike",
                year: 2018,
                playerCount: 4,
                price: 29f,
                studio: hopooGames,
                consoles: new() { pc, nSwitch },
                publisher: gearbox,
                ageRating: 13
                );
            VideoGames.Add(riskOfRain2);

            hopooGames.AddGame(riskOfRain2);
            pc.AddGame(riskOfRain2);
            nSwitch.AddGame(riskOfRain2);

            Studio ninjaKiwi = new("Ninja Kiwi", 3_000_000);
            Studios.Add(ninjaKiwi);

            Publisher ninjaKiwiPublishing = new("Ninja Kiwi Publishing", 1_000_000);
            Publishers.Add(ninjaKiwiPublishing);

            VideoGame bloonsTD6 = new(
                title: "Bloons TD 6",
                category: "Tower Defense",
                year: 2018,
                playerCount: 4,
                price: 15.49f,
                studio: ninjaKiwi,
                consoles: new() { pc },
                publisher: ninjaKiwiPublishing,
                ageRating: 9
                );
            VideoGames.Add(bloonsTD6);

            ninjaKiwi.AddGame(bloonsTD6);
            ninjaKiwiPublishing.AddStudio(ninjaKiwi);
            pc.AddGame(bloonsTD6);

            maddyMakesGamesStudio.AddGame(celeste);
            maddyMakesGamesPublishing.AddStudio(maddyMakesGamesStudio);


            VideoGame xenoblade = new(
                title: "Xenoblade Chronicles: Definitive Edition",
                category: "JRPG",
                year: 2020,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade2 = new(
                title: "Xenoblade Chronicles 2",
                category: "JRPG",
                year: 2017,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenoblade3 = new(
                title: "Xenoblade Chronicles 3",
                category: "JRPG",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame xenobladeX = new(
                title: "Xenoblade Chronicles X",
                category: "JRPG",
                year: 2015,
                playerCount: 1,
                price: 80f,
                studio: monolithSoft,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 12
            );

            VideoGame forgottenLand = new(
                title: "Kirby and the Forgotten Land",
                category: "3D Platformer",
                year: 2022,
                playerCount: 1,
                price: 80f,
                studio: halLabs,
                consoles: new() { nSwitch },
                publisher: nintendo,
                ageRating: 7
            );

            VideoGame ARKSurvivalEvolved2 = new(
                  title: "ARK: Survival Evolved 2",
                  category: "Survival",
                  year: 2022,
                  playerCount: 100,
                  price: 70f,
                  studio: WildcardStudio,
                  consoles: new() { pc },
                  publisher: WildcardPublishing,
                  ageRating: 13
                  );

            VideoGame GoatSimulator = new(
               title: "GoatSimulator",
               category: "Simulation",
               year: 2014,
               playerCount: 4,
               price: 10f,
               studio: coffeeStainStudio,
               consoles: new() { pc },
               publisher: coffeeStainPublishing,
               ageRating: 12
               );

            VideoGames.Add(ARKSurvivalEvolved2);
            WildcardStudio.AddGame(ARKSurvivalEvolved2);

            VideoGames.Add(GoatSimulator);
            coffeeStainStudio.AddGame(GoatSimulator);

            Studio FromSoftware = new("FromSoftware", 100_000);
            Studios.Add(FromSoftware);

            VideoGame EldenRing = new(
                title: "elden ring",
                category: "Action RPG",
                year: 2022,
                playerCount: 1,
                price: 60f,
                studio: FromSoftware,
                consoles: new() { pc },
                publisher: NamcoBandai,
                ageRating: 17
                );
            Studio danielMullinsGames = new("Daniel Mullins Games", 600_000);
            Studios.Add(danielMullinsGames);

            Publisher devolverDigital = new("Devolver Digital", 8_000_000);
            Publishers.Add(devolverDigital);

            VideoGame inscryption = new(
                title: "Inscryption",
                category: "Metafiction",
                year: 2021,
                playerCount: 1,
                price: 22.79f,
                studio: danielMullinsGames,
                consoles: new() { pc, nSwitch },
                publisher: devolverDigital,
                ageRating: 12
                );
            VideoGames.Add(inscryption);

            danielMullinsGames.AddGame(inscryption);
            devolverDigital.AddStudio(danielMullinsGames);
            pc.AddGame(inscryption);
            nSwitch.AddGame(inscryption);

            VideoGames.Add(xenoblade);
            VideoGames.Add(xenoblade2);
            VideoGames.Add(xenoblade3);
            VideoGames.Add(xenobladeX);
            VideoGames.Add(forgottenLand);

            monolithSoft.AddGame(xenoblade);
            monolithSoft.AddGame(xenoblade2);
            monolithSoft.AddGame(xenoblade3);
            monolithSoft.AddGame(xenobladeX);

            halLabs.AddGame(forgottenLand);

            nSwitch.AddGame(xenoblade);
            nSwitch.AddGame(xenoblade2);
            nSwitch.AddGame(xenoblade3);
            nSwitch.AddGame(forgottenLand);

            wiiU.AddGame(xenobladeX);

            pc.AddGame(satisfactory);
            pc.AddGame(celeste);

            Studio epicGames = new("Epic Games", 10_000_000);
            Studios.Add(epicGames);
            VideoGame fortnite = new(
                title: "Fortnite",
                category: "Battle Royale",
                year: 1902,
                playerCount: 100,
                price: 180f,
                studio: epicGames,
                consoles: new() { wiiU },
                publisher: nintendo,
                ageRating: 90
            );
            VideoGames.Add(fortnite);
            epicGames.AddGame(fortnite);
            wiiU.AddGame(fortnite);

            VideoGames.Add(EldenRing);
            FromSoftware.AddGame(EldenRing);
            pc.AddGame(EldenRing);
        }

        public VideoGame GetGameByName(string VideoGameName)
        {
          return VideoGames.FirstOrDefault(v => v.Title == VideoGameName);
        }
    }
}
