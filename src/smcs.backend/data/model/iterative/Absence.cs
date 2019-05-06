using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.data.model.iterative
{
    public class Absence : Iterative
    {
        internal Absence()
        {

        }

        public Absence(DateTime date, Int32 misRef, Int32 sesRef) : base(date, misRef, sesRef)
        {

        }

        //TODO فیلد ارسال نهست به یگان افزوده شود
    }
}
