using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuhaneDB;

namespace KutuphaneDB.Sorgular
{

    public class BOOKS
    {
        
        public IEnumerable<BOOK> getBook()
        {
            using (EntitiDBContext db = new EntitiDBContext())
            {
                BOOK sch = new BOOK();               
                return db.BOOKS.OrderBy(x => x.NAME).ToList();
            }                     
        }


        public bool createBook(BOOK book)
        {
            using (EntitiDBContext db = new EntitiDBContext())
            {

                db.BOOKS.Add(book);
                db.SaveChanges();
                return true;
            }  
 
        }
    }
}
