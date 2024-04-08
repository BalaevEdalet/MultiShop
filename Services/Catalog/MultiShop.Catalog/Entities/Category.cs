using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
	public class Category
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
        public String CategoryId { get; set; }
		public String CategoryName { get; set; }
	}
}
