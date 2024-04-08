﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MultiShop.Catalog.Dtos.CategoryDtos
{
	public class GetByIdCategoryDto
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public String CategoryId { get; set; }
		public String CategoryName { get; set; }
	}
}
