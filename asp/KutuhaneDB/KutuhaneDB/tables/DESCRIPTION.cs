using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneDB
{
    public class DESCRIPTION
    {
        [Key]
        public int ID { get; set; }
        //[ForeignKey("MEMBER_ID")]
        public virtual MEMBER MEMBER { get; set; }
        public string DESCRIPTION_NOTE {get; set; }
    }
}
