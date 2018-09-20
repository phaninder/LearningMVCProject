using System;
using System.Collections.Generic;
using System.Linq;
using StackOverflowProjectDomainModels;

namespace StackOverflowProject.Repositories
{
	public interface ICategoriesRepository
	{
		void InsertCategory(Category c);
		void UpdateCategory(Category c);
		void DeleteCategory(int cid);
		List<Category> GetCategories();
		List<Category> GetCategoriesByCategoryID(int cid);
	}
	public class CategoriesRepository : ICategoriesRepository
	{
		StackOverflowDatabaseDbContext db;
		
		public CategoriesRepository()
		{
			db = new StackOverflowDatabaseDbContext();
		}

		public void InsertCategory(Category c)
		{
			db.Categories.Add(c);
			db.SaveChanges();
		}

		public void UpdateCategory(Category c)
		{
			Category cs = db.Categories.Where(temp => temp.CategoryID == c.CategoryID).FirstOrDefault();
			if(cs!=null)
			{
				cs.CategoryName = c.CategoryName;
				db.SaveChanges();
			}
		}

		public void DeleteCategory(int cid)
		{
			Category c = db.Categories.Where(temp => temp.CategoryID == cid).FirstOrDefault();
			if(c!=null)
			{
				db.Categories.Remove(c);
				db.SaveChanges();
			}
		}

		public List<Category> GetCategories()
		{
			List<Category> cs = db.Categories.ToList();
			return cs;
		}

		public List<Category> GetCategoriesByCategoryID(int cid)
		{
			List<Category> cs = db.Categories.Where(temp => temp.CategoryID == cid).ToList();
			return cs;
		}

		
	}
}
