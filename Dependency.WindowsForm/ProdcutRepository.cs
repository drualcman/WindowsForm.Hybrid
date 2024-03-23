using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency.WindowsForm;
internal class ProdcutRepository
{
    List<Product> Prodcuts = [
        new Product(1, "Gafas"),
        new Product(2, "Pantalones"),
        new Product(3, "Zapatillas"),
        ];

    public Product GetProduct(int id) =>
        Prodcuts.FirstOrDefault(p => p.Id == id);
}
