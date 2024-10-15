using System.Collections.Generic;
using System.Threading.Tasks;
using AcmeStudios.ApiRefactor.DAL.Entities;

namespace AcmeStudios.ApiRefactor.DAL.Repository
{
    public interface IStudioItemRepository
    {
        Task<StudioItem> AddStudioItem(StudioItem newStudioItem);

        Task<List<StudioItem>> GetAllStudioHeaderItems();

        Task<StudioItem> GetStudioItemById(int id);

        Task<StudioItem> UpdateStudioItem(StudioItem updatedStudioItem);

        Task<bool> DeleteStudioItem(int id);

        Task<List<StudioItemType>> GetAllStudioItemTypes();
    }
}