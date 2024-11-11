namespace LearningInterfaces
{
    public class Product : IEquatable<Product>
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }

        public bool Equals(Product? otherProduct)
        {
            if (otherProduct == null) 
                return false;
            
            return Title == otherProduct.Title && Price == otherProduct.Price;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Product);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Price);
        }
    }
}
