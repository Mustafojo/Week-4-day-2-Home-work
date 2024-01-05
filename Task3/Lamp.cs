public class Lamp : IDevice
{
    public void TurnOn()
    {
        System.Console.WriteLine("The lamp is ON");
    }
    public void TurnOff()
    {
         System.Console.WriteLine("The lamp is OFF");
    }
}