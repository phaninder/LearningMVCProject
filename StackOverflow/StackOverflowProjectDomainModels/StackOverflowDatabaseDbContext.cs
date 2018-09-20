﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace StackOverflowProjectDomainModels
{
	public class StackOverflowDatabaseDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }
		public DbSet<Vote> Votes { get; set; }
	}
}
