namespace TransportChallenge;

public static class TransportResolver
{
    public static Vehicle? Resolve(string input)
    {
        return input.ToLower()
            switch
        {
            "car" => new Car(),
            "plane" => new Airplane(),
            "boat" => new Boat(),
            "helicopter" => new Helicopter(),
            "drone" => new Drone(),
            "motorcycle" => new Motorcycle(),
            "submarine" => new Submarine(),
            _ => null
        };
    }
}