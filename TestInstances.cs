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
        new Album { Id = 1, AlbumName = "III", Artist = "Portrait Decay", ListeningStatus = true },
        new Album { Id = 2, AlbumName = "Wretched Lives", Artist = "Demonic Science", ListeningStatus = false },
        new Album { Id = 3, AlbumName = "Hivemind Narcosis", Artist = "Thantifaxath", ListeningStatus = false }
    };
}

public static class DummyData {
    public static Initialization ExampleDatabase = new Initialization();
}