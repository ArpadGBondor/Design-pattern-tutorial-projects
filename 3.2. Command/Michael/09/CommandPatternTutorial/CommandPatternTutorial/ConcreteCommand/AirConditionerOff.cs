using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;

namespace CommandPatternTutorial.ConcreteCommand
{
    public class AirConditionerOff : ICommand
    {
        private AirConditioner _airConditioner;

        public AirConditionerOff(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.TurnOff();
            _airConditioner.DecreaseTemp();
        }
    }
}
