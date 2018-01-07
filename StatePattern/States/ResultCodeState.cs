using System;
namespace StatePattern.States
{
    public class ResultCodeState : StateBase
    {
        public ResultCodeState()
        {
        }

        public override void Process(Processor processor)
        {
            processor.ResultCode = 0;
            processor.State = new CompleteState();
        }
    }
}
