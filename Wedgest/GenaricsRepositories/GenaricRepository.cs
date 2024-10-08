using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Wedgest.Data;
using Wedgest.Entities;

namespace Wedgest.Repositories
{
    public class GenaricRepository<T> : IGenaricRepository<T> where T : class
    {
        #region Fields
        private readonly ApplicationContext _context;
        #endregion
        #region Constracturs
        public GenaricRepository(ApplicationContext context)
        {
            _context = context;
        }
        #endregion
        #region hamdle Methodes
        public async Task Add(T t)
        {
            //Mohamed
            var data = await _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync();
            
        }
        public async void Delete(int id)
        {
            Task<T> entityById = Get(id);
            _context.Remove(entityById);
            await _context.SaveChangesAsync();
        }
        public async Task<T> Get(int id)
        => await _context.Set<T>().FindAsync(id);
        public async Task<IEnumerable<T>> GetAll()
         => await _context.Set< T>().ToListAsync();
        public async Task Updated(int id, T t)
        {
            var UpdatedTicket =await Get(id);
            _context.Update(UpdatedTicket);
            _context.SaveChanges();
        } 
        #endregion
    }
}
