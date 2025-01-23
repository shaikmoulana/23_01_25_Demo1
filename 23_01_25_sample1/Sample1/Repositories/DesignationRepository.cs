using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Models;

namespace Sample1.Repositories
{
    public class DesignationRepository : IRepository<Designations>
    {
        private readonly DataBaseContext _context;

        public DesignationRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Designations>> GetAll()
        {
            return await _context.TblDesignation.ToListAsync();
        }

        public async Task<Designations> Get(string id)
        {
            return await _context.TblDesignation.FindAsync(id);
        }

        public async Task<Designations> Create(Designations _object)
        {
            _context.TblDesignation.Add(_object);
            await _context.SaveChangesAsync();
            return _object;
        }

        public async Task<Designations> Update(Designations _object)
        {
            _context.Entry(_object).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _object;
        }

        public async Task<bool> Delete(string id)
        {
            var data = await _context.TblDesignation.FindAsync(id);
            if (data == null)
            {
                return false;
            }

            _context.TblDesignation.Remove(data);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
