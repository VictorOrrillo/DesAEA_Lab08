using data;
using entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness
{
    public class BProduct
    {
        public List<Product> ListarProductos()
        {
            List<Product> productos = Dproduct.ListarProducts();
            return productos;
        }

        public Product BuscarPorNombre(string name)
        {
            List<Product> products = Dproduct.ListarProducts();

            foreach (var product in products)
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }

            return null;
        }
    }
}
