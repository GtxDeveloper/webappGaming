﻿using System.Collections.Generic;

namespace WebApplication.Entities
{
	public class Role
	{
		public int Id { get; set; }

		public string Name { get; set; }	

		public IEnumerable<User> Users { get; set; }

	}
}
