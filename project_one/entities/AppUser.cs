﻿using System;
namespace entityProject.entities
{
	public class AppUser
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public List<Photo> Photos { get; set; } = new();
		
	}
}

