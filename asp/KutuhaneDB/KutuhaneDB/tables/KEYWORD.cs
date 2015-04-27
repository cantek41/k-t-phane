using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneDB
{
    public class KEYWORD
    {
        [Key]
        public int ID { get; set; }
        //[ForeignKey("BOOK_ID")]
        public virtual BOOK BOOK { get; set; }
        public string KEY { get; set; }
    }
}
