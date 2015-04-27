using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuhaneDB;
using KutuphaneDB.Sorgular;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kutuphane.WebTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void testBOK()
        {
            BOOKS bks = new BOOKS();
            BOOK bk = new BOOK();
            bk.NAME = "ali";
            bks.createBook(bk);
        }


    }
}
