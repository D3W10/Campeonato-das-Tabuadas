namespace Campeonato_das_Tabuadas.Classes
{
    public class AwardData
    {
        public AwardData(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}