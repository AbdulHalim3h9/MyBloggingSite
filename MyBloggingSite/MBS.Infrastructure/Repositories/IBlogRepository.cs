using MBS.Infrastructure.Entities;

namespace MBS.Infrastructure.Repositories
{
    public interface IBlogRepository
    {
        void Delete(Guid id);
        void Dispose();
        void Get();
        List<Blog> GetBlogs();
        Blog GetById(Guid id);
        void Insert(Blog blog);
        void Save();
        void Update(Blog blog);
    }
}