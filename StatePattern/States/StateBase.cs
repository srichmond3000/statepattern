using System;
namespace StatePattern.States
{
    public abstract class StateBase
    {
        public abstract void Process(Processor processor);
    }
}

