namespace Citicon.GSM
{
    public class COM
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Description} {Name}";
        }
    }
}
