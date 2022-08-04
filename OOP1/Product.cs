using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product //Entity
        //veri tabanı proglamlama
    {
        public int Id { get; set; }
        //kategori sıralaması
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //stok adedini yazdık
        public int UnitsInStock { get; set; }

    }
}
