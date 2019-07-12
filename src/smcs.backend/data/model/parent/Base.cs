using Backend.Data.Model.Parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model.parent
{
    public abstract class Base : Enabler
    {
        protected Base()
        {
            this.Enbl = true;
        }

        internal Base(string name)
        {
            this.Name = name;
            this.Enbl = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [Required] public string Name { get; set; }
    }
}
