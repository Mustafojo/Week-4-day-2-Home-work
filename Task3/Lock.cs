public class Lock : IDevice
{
    public void TurnOn()
    {
         System.Console.WriteLine("The lock is ON");
    }
    public void TurnOff()
    {
         System.Console.WriteLine("The lock is OFF");
    }
}