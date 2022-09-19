using TestBlazor.Server.Data.Database;
using TestBlazor.Shared.Models;

namespace TestBlazor.Server.Data.Repositories
{
    public class DeveloperRepository : IDeveloperRepository
    {
        protected ApplicationDbContext _dbContext;

        public DeveloperRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddDeveloper(Developer developer)
        {
            try
            {
                developer.Id = Guid.NewGuid();
                _dbContext.Developers.Add(developer);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw new Exception("Failed to add developer");
            }
        }

        public void DeleteDeveloper(Guid id)
        {
            try
            {
                var developer = _dbContext.Developers.FirstOrDefault(u => u.Id == id);
                if (developer != null)
                {
                    _dbContext.Developers.Remove(developer);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException("Developer not found");
                }
            }
            catch (Exception)
            {

                throw new Exception("Failed to delete developer");
            }
        }

        public List<Developer> GetDeveloperDetails()
        {
            try
            {
                return _dbContext.Developers.ToList();
            }
            catch (Exception)
            {

                throw new Exception("Failed to get developers");
            }
        }

        public Developer GetDeveloperData(Guid id)
        {
            try
            {
                var developer = _dbContext.Developers.FirstOrDefault(u => u.Id == id);
                if (developer != null)
                {
                    return developer;
                }
                else
                {
                    throw new ArgumentNullException("Developer not found");
                }
            }
            catch (Exception)
            {

                throw new Exception("Failed to get developer");
            }
        }

        public void UpdateDeveloperDetails(Developer developer)
        {
            var developerToEdit = new Developer()
            {
                Id = developer.Id,
                Cellnumber = developer.Cellnumber,
                Email = developer.Email,
                Username = developer.Username,
            };

            try
            {

                _dbContext.Developers.Update(developerToEdit);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw new Exception("Failed to update developer");
            }
        }
    }

}
