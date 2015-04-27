using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneDB
{
    public class MEMBER
    {
        [Key]
        public int ID { get; set; }
        public string TC { get; set; }
        public string NAME { get; set; }
        public string  SURNAME { get; set; }
        //[ForeignKey("SCHOOL_ID")]
        public virtual SCHOOL SCHOOL { get; set; }
        public string STUDENT_NO { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string ADDRESS { get; set; }

    }
}
