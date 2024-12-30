namespace Chapter10
{
    /*
        ColumnAttribute'u sadece field ve property türlerine uygulanabilir. 
        Attribute'lar Attribute türünden türemelidir.
    */
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    internal class ColumnAttribute
        : Attribute
    {
        public string Name { get; set; }
        public bool PrimaryKey { get; set; } = false;
        public int Length { get; set; }
        public string DataType { get; set; }
    }
}
