using smcs.backend.data.model.parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model
{
    public class Session : Iterative
    {
        internal Session() : base()
        {

        }

        public Session(Int32 usrId)
        {
            this.UsrRef = usrId;
            this.InitDate = DateTime.Now;
        }

        ~Session()
        {
            this.TermDate = DateTime.Now;
        }

        [Required] [Column(TypeName = "datetime2")] public DateTime InitDate { get; set; }
        [Column(TypeName = "datetime2")] public DateTime? TermDate { get; set; }

        [Required] public Int32 UsrRef { get; set; }

        //public string ChkSum { get; set; }
    } 
}
