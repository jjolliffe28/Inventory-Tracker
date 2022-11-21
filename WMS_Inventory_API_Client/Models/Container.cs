namespace WMS_Inventory_API_Client.Models
{
    public class Container
    {
        public int? Id { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public int? StorageLocationId { get; set; }
        public virtual StorageLocation? StorageLocation { get; set; }
        public virtual List<Content>? Contents { get; set; }

        
    public Container(int? id, string? type, string? description, int? storageLocationId, StorageLocation? storageLocation, List<Content>? contentList)
    {
        Id = id;
        Type = type;
        Description = description;
        StorageLocationId = storageLocationId;
        StorageLocation = storageLocation;
        var contents = contentList ?? new List<Content>();
        Contents = contents;
    }

    public Container()
    {
        return;
    }

    }

}
