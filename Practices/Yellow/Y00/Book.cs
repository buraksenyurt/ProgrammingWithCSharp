using System;

namespace Y00;

public class Book
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Title { get; set; }
    public string Summary { get; set; }
    public decimal ListPrice { get; set; }
    public Category Category { get; set; }
    public Topic[] Topics { get; set; }
}
