using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //public bu class'a diğer katmanlar da ulaşabilsin demek
    //internal class'ın default özelliği. internal'da sadece bulunduğu katman erişebiliyor bu class'a
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }


    }
}
