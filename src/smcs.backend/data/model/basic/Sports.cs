using smcs.backend.data.model.parent;
using System;

namespace smcs.backend.data.model.basic
{
    public class Sports : Base
    {
        internal Sports() : base()
        {

        }

        public Sports(string name) : base(name)
        {
            this.Enbl = true;
        }

        public Int32 NumOfAgnts { get; set; }

        public string Desc { get; set; }
    }
}
