using MBS.Infrastructure.DbContexts;
using MBS.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Infrastructure.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private BlogDbContext _dbContext;
        public BlogRepository(BlogDbContext context)
        {
            _dbContext = context;
        }
        public Blog GetById(Guid Id)
        {
            return _dbContext.Blogs.Find(Id);
        }

        public List<Blog> GetBlogs()
        {
            return _dbContext.Blogs.ToList();
        }

        public void Insert(Blog blog)
        {
            _dbContext.Blogs.Add(blog);
        }

        public void Delete(Guid id)
        {
            _dbContext.Blogs.Remove(_dbContext.Blogs.Find(id));
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Blog blog)
        {
            if (_dbContext.Entry(blog).State == EntityState.Detached)
            {
                _dbContext.Blogs.Attach(blog);
            }

            _dbContext.Entry(blog).State = EntityState.Modified;
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
