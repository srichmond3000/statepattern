using System;
namespace StatePattern.States
{
    public class InitialState : StateBase
    {
        public InitialState()
        {
        }

        public override void Process(Processor processor)
        {
            processor.PaymentProcessorReference = string.Empty;
            processor.ResultCode = -1;

            processor.State = new PaymentProcessorState();
        }
    }
}
