using smcs.backend.data.model.parent;
using System;
using System.ComponentModel.DataAnnotations;

namespace smcs.backend.data.model.basic
{
    public class Office : Base
    {
        internal Office() : base()
        {

        }

        public Office(string name) : base(name)
        {
            this.Size = 0;
            this.Enbl = true;
        }

        [Required] public Int32 Size { get; set; }

        public string Desc { get; set; }
    }
}
