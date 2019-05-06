using smcs.backend.data.model.parent;

namespace smcs.backend.data.model
{
    public class Signature : Base
    {
        internal Signature() : base()
        {

        }

        public Signature(string name, string pers) : base(name)
        {
            this.Person = pers;
        }

        public string Person { get; set; }
    }
}
