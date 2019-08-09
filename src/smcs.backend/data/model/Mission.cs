using Backend.Data.Model.Parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model
{
    public class Mission
    {
        internal Mission()
        {

        }

        public Mission(DateTime init, Int32 sprtRef, Int32 offcRef, string ordr, Int32 sesRef)
        {
            this.InitDate = init;
            this.DeadLine = init.AddMonths(3); // مدت پیش‌فرض ماموریت 3ماه است
            this.SprtRef = sprtRef;
            this.OrdrBy = ordr;
            this.OffcRef = offcRef;
            this.SesRef = sesRef;
            this.TimeStmp = DateTime.Now;
            this.Last = true; // ماموریت ایجاد شده، جدیدترین ماموریت مامور است
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required] public Int32 MisId { get; set; }
        [Required] [Column(TypeName = "datetime2")] public DateTime InitDate { get; set; }
        [Column(TypeName = "datetime2")] public DateTime? Ret2UntDate { get; set; }
        [Required] [Column(TypeName = "datetime2")] public DateTime DeadLine { get; set; } // تاریخ انقضای ماموریت
        [Required] public Int32 SprtRef { get; set; }
        public Int32 OffcRef { get; set; }
        [Required] public string OrdrBy { get; set; } // پذیرش به دستور چه کسی انجام پذیرفته
        [Required] public Int32 SesRef { get; set; }
        [Required] [Column(TypeName = "datetime2")] public DateTime TimeStmp { get; set; } // تاریخ‌وزمان آخرین بروز‌رسانی
        public bool Last { get; set; }

        public string InitDesc { get; set; }
        public string TermDesc { get; set; }        

        //TODO فیلد ارسال پایان به یگان افزوده شود
    }
}
