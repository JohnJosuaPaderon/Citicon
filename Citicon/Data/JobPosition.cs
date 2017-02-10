namespace Citicon.Data
{
    public class JobPosition
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
