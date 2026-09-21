namespace Metallix;
using Metallix.Models;


//Dummydata för test
public class Initialization{
    public List<Band> BandList = new(){
        new Band { Id = 1, Name = "Portrait Decay", Genre = "Experimental Black Metal", Active = true },
        new Band { Id = 2, Name = "Demonic Science", Genre = "Melodic Death Metal", Active = true}
    };

    public List<Album> AlbumList = new()
    {
        new Album { id = 1, albumName = "III", artist = "Portrait Decay", listeningStatus = true },
        new Album { id = 2, albumName = "Wretched Lives", artist = "Demonic Science", listeningStatus = false },
        new Album { id = 3, albumName = "Hivemind Narcosis", artist = "Thantifaxath", listeningStatus = false }
    };
}

public static class DummyData {
    public static Initialization ExampleDatabase = new Initialization();
}