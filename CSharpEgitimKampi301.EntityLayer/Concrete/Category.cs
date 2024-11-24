using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }




    }
}
/*
int x; ---> direk sınıf içine tanımlıysa field olarak tanımlanır
Eğer ki  bir değer yapısı sonuna get set alırsa property olur
Eğer ki bir değer metot içinde tanımlanırsa değişken olur

    */
