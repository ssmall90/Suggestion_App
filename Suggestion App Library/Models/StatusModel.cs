﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suggestion_App_Library.Models
{
    public class StatusModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}

