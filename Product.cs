using System.Collections.Generic;
using System.Linq;

public class Products
{
    public int ID {set; get;}
    public string Name {set; get;}         // tên
    public double Price {set; get;}        // giá
    public string[] Colors {set; get;}     // cá màu
    public int Brand {set; get;}           // ID Nhãn hiệu, hãng
    public Products(int id, string name, double price, string[] colors, int brand) 
    {
        ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    // Lấy chuỗi thông tin sản phẳm gồm ID, Name, Price
    override public string ToString() 
        => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";


    public static void ProductPrice500(List<Products> products)
    {
        var ketqua = from product in products
            where product.Price == 400
            select product;

        foreach (var product in ketqua)
            Console.WriteLine(product.ToString());
    }

    public static void ProductNameColor(List<Products> products){
        var ketqua = from product in products
             select new {
                ten = product.Name.ToUpper(),
                mausac = string.Join(',', product.Colors)
             };

        foreach (var item in ketqua) {
            Console.WriteLine(item.ten + " - " + item.mausac);
        }
    }

    public static void ProductColorYellow(List<Products> products){
        var ketqua = from product in products
                from color in product.Colors
                where product.Price < 500
                where color == "Vàng"
                select product;

        foreach (var product in ketqua) {
            Console.WriteLine(product.ToString());
        }
    }

    public static void ProductPriceDESC(List<Products> products){
        var ketqua = from product in products
            where product.Price <= 300
            orderby product.Price descending
            select product;

        foreach (var product in ketqua) {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }
    }

    public static void ProductGroupBy(List<Products> products){
        // var ketqua = from product in products
        //     where product.Price >=400 && product.Price <= 500
        //     group product by product.Price;

        var ketqua = from product in products
                    where product.Price >=400 && product.Price <= 500
                    group product by product.Price into gr
                    orderby gr.Key descending
                    select gr;

        foreach (var group in ketqua)
        {
            Console.WriteLine(group.Key);
            foreach (var product in group)
            {
                Console.WriteLine($"    {product.Name} - {product.Price}");
            }

        }
    }

    public static void ProductPriceCount(List<Products> products){
        var ketqua = from product in products 
                    group product by product.Price into gr
                    let count = gr.Count()
                    select new {
                        price = gr.Key,
                        num_product = count
                    };
        
        foreach(var item in ketqua){
            Console.WriteLine($"{item.price} - {item.num_product}");
        }
    }

    public static void ProductInnerJoinBrand(List<Products> products, List<Brand> brands){
        var ketqua = from product in products
                    join brand in brands on product.Brand equals brand.ID
                    select new {
                        name  = product.Name,
                        brand = brand.Name,
                        price = product.Price
                    };

        foreach(var item in ketqua){
            Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
        }
    }

    public static void ProductLeftJoinBrand(List<Products> products, List<Brand> brands){
        var ketqua = from product in products 
                    join brand in brands on product.Brand equals brand.ID into t
                    from brand in t.DefaultIfEmpty()
                    select new {
                        name  = product.Name,
                        brand = (brand == null) ? "NO-BRAND" : brand.Name,
                        price = product.Price
                    };

        foreach (var item in ketqua)
        {
            Console.WriteLine($"{item.name,10} {item.price, 4} {item.brand,12}");
        }         
    }
}