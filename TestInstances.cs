namespace Metallix;
using Metallix.Models;


//Dummydata för test
public class Initialization{

    public List<Album> AlbumList = new()
    {
        new Album { id = 1, albumName = "III", artist = "Portrait Decay", listeningStatus = true, imageURL = "/uploads/PortraitDecay-III.png" },
        new Album { id = 2, albumName = "Wretched Lives", artist = "Demonic Science", listeningStatus = false, imageURL = "/uploads/DemonicScience-WretchedLives.png"},
        new Album { id = 3, albumName = "Hivemind Narcosis", artist = "Thantifaxath", listeningStatus = false, imageURL = "/uploads/Thantifaxath-HiveMindNarcosis.png" }
    };
}

public static class DummyData {
    public static Initialization ExampleDatabase = new Initialization();
}