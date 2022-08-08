using System;
using System.Collections.Generic;
using System.Linq;


namespace Program{
    public class Product{
        public static void Main(string[] args){
            var brands = new List<Brand>() {
                new Brand{ID = 1, Name = "Công ty AAA"},
                new Brand{ID = 2, Name = "Công ty BBB"},
                new Brand{ID = 4, Name = "Công ty CCC"},
            };

            var products = new List<Products>()
            {
                new Products(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Products(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Products(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Products(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Products(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Products(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Products(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
            };

            Products.ProductPrice500(products);

            Console.WriteLine("--------------");

            Products.ProductNameColor(products);

            Console.WriteLine("--------------");

            Products.ProductColorYellow(products);

            Console.WriteLine("--------------");

            Products.ProductPriceDESC(products);

            Console.WriteLine("--------------");

            Products.ProductGroupBy(products);

            Console.WriteLine("--------------");

            Products.ProductPriceCount(products);

            Console.WriteLine("--------------");

            Products.ProductInnerJoinBrand(products, brands);

            Console.WriteLine("--------------");

            Products.ProductLeftJoinBrand(products, brands);
        }
    }
}