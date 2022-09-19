using TestBlazor.Shared.Models;

namespace TestBlazor.Server.Data.Repositories
{
    public interface IDeveloperRepository
    {
        public List<Developer> GetDeveloperDetails();
        public void AddDeveloper(Developer developer);
        public void UpdateDeveloperDetails(Developer developer);
        public Developer GetDeveloperData(Guid id);
        public void DeleteDeveloper(Guid id);
    }
}
