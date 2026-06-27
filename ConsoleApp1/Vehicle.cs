using System.Security.Cryptography.X509Certificates;

namespace TransportChallenge;

public abstract class Vehicle
{
    public abstract string Move();
    public Vehicle()
    {
        // Console.WriteLine("Test");
    }
}
