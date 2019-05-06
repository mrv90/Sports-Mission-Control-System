using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.data.model.iterative
{
    public class OnDuty : Iterative
    {
        internal OnDuty()
        {

        }

        public OnDuty(DateTime date, Int32 misRef, Int32 sesRef) : base(date, misRef, sesRef)
        {

        }
    }
}
