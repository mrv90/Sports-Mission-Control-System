using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model.parent
{
    /// <summary>
    /// کلاس والد برای موجودیت‌های پایه
    /// </summary>
    public abstract class Base
    {
        protected Base()
        {

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

        public bool Enbl { get; set; }
    }
}
