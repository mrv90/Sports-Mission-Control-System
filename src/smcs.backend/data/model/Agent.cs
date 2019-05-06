using smcs.backend.data.model.parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model
{
    public class Agent : Base
    {
        internal Agent() : base()
        {

        }

        public Agent(string name, Int32 rankRef, string fthr, string ntio, DateTime disp,
                     string cntc, string emg, Int32 unitRef, Int32 misRef) : base(name)
        {
            this.RnkRef = rankRef;
            this.FthrName = fthr;
            this.NtioCode = ntio;
            this.DateOfDisp = disp;
            this.Cntc = cntc;
            this.ECntc = emg;
            this.UntRef = unitRef;
            this.MisRef = misRef;
            
            this.TimeStmp = DateTime.Now;
        }

        ~Agent()
        {
            this.Enbl = false; // پس از پایان‌زدن مامور، هم ماموریت و هم خود مامور را غیرفعال می‌کنیم
        }

        [Required] public Int32 RnkRef { get; set; }
        [Required] public string FthrName { get; set; }
        [Required] public string NtioCode { get; set; }
        [Required] [Column(TypeName = "datetime2")] public DateTime DateOfDisp { get; set; }
        [Required] public string Cntc { get; set; } 
        public string ECntc { get; set; }
        [Required] public string Addr { get; set; } 
        [Column(TypeName = "datetime2")] public DateTime? RecpDate { get; set; }
        [Required] public Int32 UntRef { get; set; }
        [Required] public Int32 MisRef { get; set; }
        [Required] [Column(TypeName = "datetime2")] public DateTime TimeStmp { get; set; } // تاریخ‌وزمان آخرین بروز‌رسانی

        public string PersCode { get; set; } 
        public string Desc { get; set; }
    }
}
