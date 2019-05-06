using smcs.backend.data.model.parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model
{
    public class History
    {
        internal History()
        {

        }

        public History(Iterative type, string ent, string ag)
        {
            this.Type = type;
            this.Entity = ent;
            this.Agent = ag;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [Required] public Iterative Type { get; set; }

        [Required] public string Entity { get; set; }

        public string Agent { get; set; }
    }
}
