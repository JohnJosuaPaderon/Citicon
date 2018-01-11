namespace Citicon.Data
{
    public class Department : EntityBase<long>
    {
        static Department()
        {
            Operation = new Department() { Id = 4 };
        }

        public static Department Operation { get; }
        
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
