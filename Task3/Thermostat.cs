public class Themostat : IDevice
{
    public void TurnOn()
    {
         System.Console.WriteLine("The Themostat is ON");
    }
    public void TurnOff()
    {
         System.Console.WriteLine("The Themostat is OFF");
    }
}