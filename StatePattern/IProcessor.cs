using System;
using StatePattern.States;

namespace StatePattern
{
    public interface IProcessor
    {
        StateBase State { get; set; }

        string PaymentProcessorReference { get; set; }

        int ResultCode { get; set; }

        void Process();
    }
}
