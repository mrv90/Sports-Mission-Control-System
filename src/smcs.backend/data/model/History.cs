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

        public History(Crud type, string ent, Int32 id)
        {
            this.Type = type;
            this.Entity = ent;
            this.entId = ag;
            this.TimeStmp = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [Required] public Crud Type { get; set; }

        [Required] public string Entity { get; set; }

        public Int32 entId { get; set; }

        [Required] [Column(TypeName = "datetime2")] public DateTime TimeStmp { get; set; }
    }
}
