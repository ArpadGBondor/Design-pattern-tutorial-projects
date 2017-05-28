using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;

namespace CommandPatternTutorial.ConcreteCommand
{
    public class LightOn : ICommand
    {
        private Light _light;

        public LightOn(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
