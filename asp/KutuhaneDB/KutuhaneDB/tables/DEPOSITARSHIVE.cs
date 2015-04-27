﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuhaneDB
{
    public class DEPOSITARSHIVE
    {
        [Key]
        public int ID { get; set; }
        //[ForeignKey("DEPOSITACTUEL_ID")]
        public virtual DEPOSITACTUEL DEPOSITACTUEL { get; set; }

        //[ForeignKey("MEMBER_ID")]
        public virtual MEMBER MEMBER { get; set; }
        //[ForeignKey("BOOK_ID")]
        public virtual BOOK BOOK_ID { get; set; }
        public DateTime OUTDATE { get; set; }
        public DateTime? INDATE { get; set; }
        public DateTime? DEFAULT_INDATE { get; set; }
    }
}
