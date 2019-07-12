using Backend.Data.Model.Parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model.parent
{
    /// <summary>
    /// کلاس والد برای موجودیت‌های دوره‌ای
    /// </summary>
    public abstract class Iterative : Enabler
    {
        internal Iterative()
        {

        }

        internal Iterative(DateTime date, Int32 misRef, Int32 sesRef)
        {
            this.Date = date;
            this.MisRef = misRef;
            this.SesRef = sesRef;

            this.TimeStmp = DateTime.Now;
            this.Enbl = true;
            this.TotalDays++;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [Required] [Column(TypeName = "datetime2")] public DateTime Date { get; set; }

        [Required] public Int32 MisRef { get; set; }
        [Required] public Int32 SesRef { get; set; } // توجه شود که فرزندان این کلاس همه وابسته به ماموریت‌ورزشی هستند

        [Required] public DateTime TimeStmp { get; set; }

        public Int32 TotalDays { get; protected set; } = 0;
        public string Desc { get; set; }
    }
}
