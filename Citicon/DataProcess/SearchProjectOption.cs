using Citicon.Data;

namespace Citicon.DataProcess
{
    public class SearchProjectOption : EntityBase<ushort>
    {
        static SearchProjectOption()
        {
            Name = new SearchProjectOption(1, nameof(Name), "Project Name");
            ClientName = new SearchProjectOption(2, nameof(ClientName), "Client Name");
        }

        public static SearchProjectOption Name { get; }
        public static SearchProjectOption ClientName { get; }

        private SearchProjectOption(ushort id, string key, string description)
        {
            Id = id;
            Key = key;
            Description = description;
        }

        public string Key { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
