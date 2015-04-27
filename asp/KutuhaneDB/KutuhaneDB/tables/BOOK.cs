using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneDB
{
    public class BOOK
    {
        public BOOK()
        {
 
        }
        [Key]
        public int ID { get; set; }
        public string BARCODE { get; set; }
        public string STOCK { get; set; }
        public string ISBN_NO { get; set; }
        public string  NAME { get; set; }
        //[ForeignKey("WRITER_ID")]
        public virtual WRITER WRITER { get; set; }
        //[ForeignKey("TYPE_ID")]
        public virtual TYPE TYPE { get; set; }
        //[ForeignKey("PUBLISHER_ID")]
        public virtual PUBLISHER PUBLISHER { get; set; }
        public string DESCRIPTION { get; set; }
        

    }
}
