namespace Metallix;
using Metallix.Models;


//Dummydata för test
public class Initialization{
    public List<Band> BandList = new(){
        new Band { Id = 1, Name = "Portrait Decay", Genre = "Experimental Black Metal", Active = true },
        new Band { Id = 2, Name = "Demonic Science", Genre = "Melodic Death Metal", Active = true}
    };
}

public static class DummyData {
    public static Initialization ExampleDatabase = new Initialization();
}