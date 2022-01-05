using ActionCzernowitz.BLL.DTOs;
using ActionCzernowitz.BLL.Interfaces.IServices;
using ActionCzernowitz.DAL.EF;
using ActionCzernowitz.DAL.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ActionCzernowitz.BLL.Services
{
    public class NewService : BaseService<New>, INewService
    {
        public NewService(ApplicationContext context,
            IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<NewDto> GetByIdAsync(Guid id)
        {
            var news = await Entities.FirstOrDefaultAsync(n => n.Id.Equals(id));

            return _mapper.Map<NewDto>(news);
        }

        public async Task<IEnumerable<NewDto>> GetAllAsync()
        {
            var news = await Entities.ToListAsync();

            return _mapper.Map<IEnumerable<NewDto>>(news);
        }

        public async Task<NewDto> CreateAsync(NewDto newDto)
        {
            var news = await InsertAsync(_mapper.Map<New>(newDto));

            await _context.SaveChangesAsync();

            return _mapper.Map<NewDto>(news);
        }

        public async Task<NewDto> UpdateAsync(NewDto newDto)
        {
            var news = _mapper.Map<New>(newDto);

            Update(news);
            await _context.SaveChangesAsync();

            return newDto;
        }

        public async Task<NewDto> DeleteByIdAsync(Guid id)
        {
            var news = await Entities.AsNoTracking()
                .FirstAsync(n => n.Id.Equals(id));

            Delete(news);
            await _context.SaveChangesAsync();

            return _mapper.Map<NewDto>(news);
        }
    }
}
