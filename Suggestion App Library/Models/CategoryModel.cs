﻿namespace Suggestion_App_Library.Models
{
    public class CategoryModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }

}

