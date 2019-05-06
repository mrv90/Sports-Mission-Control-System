using smcs.backend.data.model.parent;
using System.ComponentModel.DataAnnotations;

namespace smcs.backend.data.model.basic
{
    public class Rank : Base
    {
        internal Rank() : base()
        {

        }

        public Rank(string shName, string fllName, string clss) : base(fllName)
        {
            this.ShrtName = shName;
            this.Class = clss;
            this.Enbl = true;
        }

        [Required] public string Class { get; set; }
        [Required] public string ShrtName { get; set; }

        public string Desc { get; set; }
    }
}
