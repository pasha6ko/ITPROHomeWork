namespace ITPROHomeWork
{
    public class Shop
    {
        public string Name { get; private set; }
        public double Rate { get => rating; private set => rating = Math.Round(value, 1); }
        private double rating;
        public Dictionary<Product, int> Products { get; private set; }
        public float Deposit { get; private set; }
        public Shop(string name, float rate)
        {
            Rate = rate;
            Name = name;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Rate);
            Console.WriteLine("________________Products________________");
            foreach (Product prod in Products.Keys)
            {
                Console.WriteLine($"{prod.Name}: Цена:{prod.Price} Количество:{Products[prod]}");
            }

        }
        public void AddProduct(int id, string name, float price, int count)
        {
            if (!InStrore(name))
            {
                Products.Add(new Product(id, name, price), count);
            }
            else
            {
                Products[GetAvaliableProduct(name)] += count;
            }
        }
        public bool InStrore(string searchKey)
        {
            foreach (Product product in Products.Keys)
            {
                if (product.Name.Contains(searchKey)) return true;
            }
            return false;
        }
        public Product GetAvaliableProduct(string searchKey)
        {
            foreach (Product product in Products.Keys)
            {
                if (product.Name.Contains(searchKey)) return product;
            }
            return null;
        }
        public void SellProduct(Product product, int count)
        {
            if (!InStrore(product.Name))
                return;
            if (Products[product] >= count)
            {
                Deposit += product.Price;
                Products[product] -= count;
                if (Products[product] == 0);
                {
                    Products.Remove(product);
                }
            }
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get => price; private set => Math.Round(value, 2); }
        private float price;
        public Product(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

    }

}
