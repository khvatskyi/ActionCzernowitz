using ActionCzernowitz.DAL.EF;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ActionCzernowitz.BLL.Services
{
    public abstract class BaseService<T>
        where T : class
    {
        protected readonly ApplicationContext _context;
        protected readonly IMapper _mapper;

        protected DbSet<T> Entities => _context.Set<T>();

        protected BaseService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        protected T Delete(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            Entities.Remove(entity);
            return entity;
        }

        protected async Task<T> InsertAsync(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            return (await Entities.AddAsync(entity)).Entity;
        }

        protected T Update(T entity)
        {
            if (entity == null)
            {
                throw new NotImplementedException();
            }

            Entities.Update(entity);
            return entity;
        }
    }
}
