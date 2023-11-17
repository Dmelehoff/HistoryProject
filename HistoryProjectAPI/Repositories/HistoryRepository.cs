using System.Collections.Generic;
using System.Linq;
using HistoryProjectAPI.Database;
using HistoryProjectAPI.Interfaces.Repositories;
using HistoryProjectAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace HistoryProjectAPI.Repositories
{
    public class HistoryRepository : IHistoryRepository
    {
        private readonly DbSet<History> _dbSet;
        private readonly ApplicationDbContext _dbContext;

        public HistoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Histories;
        }

        public History AddHistory(History history)
        {
            _dbSet.Add(history);
            _dbContext.SaveChanges();

            return history;
        }

        public History GetHistoryById(int id)
        {
            return _dbSet.SingleOrDefault(history => history.Id == id);
            /*
             * SELECT * FROM [Histories]
             * WHERE [Id] = @id;
             */
        }

        public List<History> GetHistories()
        {
            return _dbSet.ToList();
            /*
            * SELECT * FROM [Histories];
            */
        }

        public int GetHistoriesTotalCount()
        {
            return _dbSet.Count();
            /*
            * SELECT COUNT(1) FROM [Histories];
            */
        }
    }
}
