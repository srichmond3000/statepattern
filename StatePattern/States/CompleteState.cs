using System;
namespace StatePattern.States
{
    public class CompleteState : StateBase
    {
        public CompleteState()
        {
        }

        public override void Process(Processor processor)
        {
            // marker state for completion of processing.
        }
    }
}
