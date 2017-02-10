namespace Citicon.Data
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
