﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace entityProject.entities
{
	[Table("Photos")]
	public class Photo
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Description { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}

