namespace LearningInterfaces
{
    internal class Program
    {
        static void Main()
        {
            #region IEnumerable<GameEntity> Örneği

            var gameWorld = new World();
            foreach (var entity in gameWorld)
            {
                Console.WriteLine(entity.Id);
            }

            #endregion

            #region IComparable<Category> Örneği


            var categories = new List<Category>
            {
                new() { Title = "Elektronik"},
                new() { Title = "Beyaz Eşya"},
                new() { Title = "Züccaciye"},
                new() { Title = "Kitap"},
                new() { Title = "Kırtasiye"},
                new() { Title = "Dergi"},
                new() { Title = "Gazete"},
            };
            categories.Sort();
            foreach (var category in categories)
            {
                Console.WriteLine(category.Title);
            }

            #endregion

            #region IFormattable Örneği

            var currentTemperature = new Temperature { Celsius = 18 };
            Console.WriteLine(currentTemperature.ToString("C", null));
            Console.WriteLine(currentTemperature.ToString("F", null));

            #endregion

            #region IEquatable Örneği

            var prd1 = new Product { Title = "ElGi Tv", Price = 999.99M };
            var prd2 = new Product { Title = "ElGi T", Price = 999.99M };
            Console.WriteLine("Product 1 ile Product 2 verileri eşit mi? {0}", prd1.Equals(prd2));

            #endregion

            #region INotifyPropertyChanged Örneği

            var obiWanKenobi = new Player();
            obiWanKenobi.Score = 10;
            obiWanKenobi.PropertyChanged += (sender, args) =>
            {
                if (args is ScorePropertyChangedEventArgs e)
                {
                    Console.WriteLine($"{e.PropertyName} değeri {e.OldValue} ' dan {e.NewValue} olarak değişti!");
                }
            };
            obiWanKenobi.Score = 23;

            #endregion
        }
    }
}
