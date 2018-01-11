namespace Citicon.Data
{
    public class JobPosition : EntityBase<long>
    {
        public string Name { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
