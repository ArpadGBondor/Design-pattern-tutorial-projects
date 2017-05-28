using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;

namespace CommandPatternTutorial.ConcreteCommand
{

    public class LightOff : ICommand
    {
        private Light _light;

        public LightOff(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
