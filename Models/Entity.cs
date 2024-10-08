namespace MyCrudApp.Models
{
    public class Entity
    {

        
        public string Id { get; set; }  // MongoDB usa string como tipo de ID (ObjectId)
        public string Name { get; set; }
        public string Description { get; set; }

        
    }
}
