using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.data.model.basic
{
    public class Unit : Base
    {
        internal Unit() : base()
        {

        }

        public Unit(string name) : base(name)
        {
            this.Size = 0;
            this.Enbl = true;
        }

        //TODO در زمان پذیرش باید تعداد مامور افزایش یابد
        public Int32 Size { get; set; }

        public string Desc { get; set; }
    }
}
