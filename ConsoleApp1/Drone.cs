namespace TransportChallenge;

public class Drone : Vehicle, IFlyable, IDriveable
{
    public override string Move() => "m";
}
