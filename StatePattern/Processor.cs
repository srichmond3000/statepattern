using System;
using StatePattern.States;

namespace StatePattern
{
    public class Processor : IProcessor
    {
        public Processor()
        {
            State = new InitialState();
        }

        public StateBase State { get; set; }

        public string PaymentProcessorReference { get; set; }

        public int ResultCode { get; set; }

        public void Process()
        {
            while(!(State is CompleteState))
            {
                Console.WriteLine(this.ToString());
                State.Process(this);
            }
        }

        public override string ToString()
        {
            return string.Format("[Processor: State={0}, PaymentProcessorReference={1}, ResultCode={2}]", State, PaymentProcessorReference, ResultCode);
        }
    }
}
