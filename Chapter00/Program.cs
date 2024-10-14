// var trackingSystem = new Homework(); // Default Constructor
var trackingSystem = new Homework(
    Guid.NewGuid()
    , "Inventory Tracking System"
    , "Bu projede amaç basit bir envanter takip sistemi geliştirilmesidir."
    , 70);

Console.WriteLine("{0}", trackingSystem.Title);

// var apiGateway = new Homework();

object obj = trackingSystem;

// trackingSystem.Title="Inventory";


List<Homework> homeworks =
[
    trackingSystem,
    new Homework(
        Guid.NewGuid()
        , "Random Data Generator"
        , "Rastgele veri oluşturma aracı"
        , 90)
];

// List<Homework> homeworks = new List<Homework>();
// homeworks.Add(trackingSystem);
// homeworks.Add(
//     new Homework(
//         Guid.NewGuid()
//         , "Random Data Generator"
//         , "Rastgele veri oluşturma aracı"
//         , 90)
//     );

// var randomGenerator = new Homework();
// Console.WriteLine("{0}", randomGenerator);

// float pi = 3.14F;
// var square= pi *2 *2;


// Set Fields
// trackingSystem.Id = Guid.NewGuid();
// trackingSystem.Title = "Inventory Tracking System";
// trackingSystem.Summary = "Bu projede amaç basit bir envanter takip sistemi geliştirilmesidir.";
// trackingSystem.Level = 70;

// Print Out
// Console.WriteLine("{0} (L:{2})\n\t{1}", trackingSystem.Title, trackingSystem.Summary, trackingSystem.Level);
Console.WriteLine("{0}", trackingSystem);

// Entity Design
class Homework(Guid id, string title, string summary, short level) // Primary Constructor
{
    // Read-only Properties
    public Guid Id { get; private set; } = id;
    public string Title { get; private set; } = title;
    public string Summary { get; private set; } = summary;
    public short Level { get; private set; } = level;
    // public Homework()
    // {

    // }
    // public Homework(Guid id, string title, string summary, short level)
    // {
    //     Id = id;
    //     Title = title;
    //     Summary = summary;
    //     Level = level;
    // }
    public override string ToString()
    {
        return $"{Id}:{Title}(L:{Level})\n\t{Summary}";
    }
}

// class Homework
// {
//     Guid _id;
//     public void SetId()
//     {
//         _id = Guid.NewGuid();
//     }
//     public Guid Id()
//     {
//         return _id;
//     }
//     string? _title;
//     public void SetTitle(string title){
//         if(string.IsNullOrEmpty(title)) {
//             throw new ArgumentException("There is no title");
//         }
//         _title=title;
//     }
//     string? Summary;
//     short Level;
//     public override string ToString()
//     {
//         return $"{Id}:{Title}(L:{Level})\n\t{Summary}";
//     }
// }
