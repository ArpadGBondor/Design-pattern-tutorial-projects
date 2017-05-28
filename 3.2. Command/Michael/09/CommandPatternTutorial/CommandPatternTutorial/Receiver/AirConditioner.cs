using System;

namespace CommandPatternTutorial.Receiver
{
    public class AirConditioner
    {
        public void TurnOn()
        {
            Console.WriteLine("Air conditioner is on!");
        }

        public void TurnOff()
        {
            Console.WriteLine("Air conditioner off!");
        }

        public void IncreaseTemp()
        {
            Console.WriteLine("Increasing temperature.");
        }

        public void DecreaseTemp()
        {
            Console.WriteLine("Decreasing temperature.");
        }
    }
}
