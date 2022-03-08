namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product);
        }

        public bool Equals(Product productToFind)
        {
            if (productToFind == null)
                return false;

            return this.Name.Equals(productToFind.Name) && this.Price.Equals(productToFind.Price);
        }
    }
}
