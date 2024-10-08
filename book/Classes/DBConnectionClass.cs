using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book.Datadase;

namespace book.Classes
{
    internal class DBConnectionClass
    {
        public static BookEntities DatabaseConnection = new BookEntities();
    }
}
