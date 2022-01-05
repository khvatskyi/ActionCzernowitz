using ActionCzernowitz.BLL.DTOs;

namespace ActionCzernowitz.BLL.Interfaces.IServices
{
    public interface INewService
    {
        Task<NewDto> GetByIdAsync(Guid id);

        Task<IEnumerable<NewDto>> GetAllAsync();

        Task<NewDto> CreateAsync(NewDto newDto);

        Task<NewDto> UpdateAsync(NewDto newDto);

        Task<NewDto> DeleteByIdAsync(Guid id);
    }
}
