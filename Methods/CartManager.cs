using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class CartManager
    {
        public void addProduct(Product product) 
        {
            Console.WriteLine("OK! Product added : " + product.ProductName);
        }

        //class oluşturup ürün eklemeyi classın nesnesi şeklinde eklemek yerine aşağıdaki 
        //methodda olduğu gibi ayrı ayrı parametre şekline almamız yanlış bir hareket olur. 
        //Bu hareket yzılımımızın muhtemel değişim durumlarında dezavantaj haline gelecek.
        public void addProduct2(string productName, string productDescription, double productPrice) 
        {  
            Console.WriteLine("OK! Product added : " + productName); 
        }
    }
}
