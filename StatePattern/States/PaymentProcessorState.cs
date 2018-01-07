using System;
namespace StatePattern.States
{
    public class PaymentProcessorState : StateBase
    {
        public PaymentProcessorState()
        {
        }

        public override void Process(Processor processor)
        {
            processor.PaymentProcessorReference = "payment processor reference";
            processor.State = new ResultCodeState();
        }
    }
}
