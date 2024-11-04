namespace LearningInterfaces
{
    public class Category 
        : IComparable<Category>
    {
        public string? Title { get; set; }

        public int CompareTo(Category? other)
        {
            if (other == null)
                return 1;

            return Title.CompareTo(other.Title);
        }
    }
}
