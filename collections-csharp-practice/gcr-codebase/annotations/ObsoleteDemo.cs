using System;

class LegacyAPI{
    [Obsolete("OldFeature is deprecated. Use NewFeature instead.")]
    public void OldFeature(){
        Console.WriteLine("Old feature running");
    }

    public void NewFeature(){
        Console.WriteLine("New feature running");
    }
}

class ObsoleteDemo{
    static void Main(){
        LegacyAPI api= new LegacyAPI();
        api.OldFeature(); 
        api.NewFeature();
    }
}
