using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
    {
        private static readonly List<Game> games = new()
        {
            new Game(){
            Id = 1,
            Name = "Call of Duty",
            Genre = "Shooter",
            Price = 59.99m,
            ReleaseDate = new DateTime(2012, 2, 2)
        },
            new Game(){
            Id = 2,
            Name = "NBA 2k24",
            Genre = "Sports",
            Price = 79.99m,
            ReleaseDate = new DateTime(2024, 4, 1)
        },new Game(){
            Id = 3,
            Name = "FIFA 23",
            Genre = "Sports",
            Price = 39.99m,
            ReleaseDate = new DateTime(2023, 2, 1)
        }
    };

    public static Game[] GetGames()
    {
        return games.ToArray();
    }

    public static void AddGame(Game game)
    {
        games.Add(game);
    }

}