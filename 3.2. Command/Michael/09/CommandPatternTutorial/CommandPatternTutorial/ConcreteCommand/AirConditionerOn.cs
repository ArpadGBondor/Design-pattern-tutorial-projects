using CommandPatternTutorial.AbstractCommand;
using CommandPatternTutorial.Receiver;

namespace CommandPatternTutorial.ConcreteCommand
{

    public class AirConditionerOn : ICommand
    {
        private AirConditioner _airConditioner;

        public AirConditionerOn(AirConditioner airConditioner)
        {
            _airConditioner = airConditioner;
        }

        public void Execute()
        {
            _airConditioner.TurnOn();
            _airConditioner.IncreaseTemp();
        }
    }
}
