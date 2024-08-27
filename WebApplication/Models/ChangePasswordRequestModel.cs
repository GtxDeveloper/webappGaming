using System.Linq;
using WebApplication.Entities;

namespace WebApplication.Models
{
    public class ChangePasswordRequestModel
    {
        private GamePortalDbContext _dbContext;

        public ChangePasswordRequestModel(GamePortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ChangePasswordRequest GetRequestById(int id)
        {
            return _dbContext.ChangePasswordRequests.FirstOrDefault(x => x.Id == id);
        }

        public bool AddRequest(ChangePasswordRequest request)
        {
            _dbContext.ChangePasswordRequests.Add(request);
            return _dbContext.SaveChanges() == 1 ? true : false; 
        }

        public int GetCount()
        {
            return _dbContext.ChangePasswordRequests.Count();
        }

        public ChangePasswordRequest GetRequestByHash(string hash)
        {
            return _dbContext.ChangePasswordRequests.FirstOrDefault(x => x.Hash == hash);
        }
    }
}
