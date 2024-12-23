namespace Chapter09
{
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
