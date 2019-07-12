using Backend.Data.Model.Parent;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace smcs.backend.data.model
{
    public class User : Enabler
    {
        internal User()
        {

        }

        public User(string name, string usrName, string pass)
        {
            this.Name = name;
            this.UsrName = usrName;
            this.Pass = pass;

            this.TimeStmp = DateTime.Now;
            this.Enbl = true;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 UsrId { get; set; }

        [Required] public string Name { get; set; }
        [Required] public string UsrName { get; set; }
        [Required] public string Pass { get; set; }
        [Required] public DateTime TimeStmp { get; set; }

        public string Desc { get; set; }
    }
}
