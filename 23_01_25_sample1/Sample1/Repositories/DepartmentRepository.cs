using Microsoft.EntityFrameworkCore;
using Sample1.Data;
using Sample1.Models;

namespace Sample1.Repositories
{
    public class DepartmentRepository : IRepository<Departments>
    {
        private readonly DataBaseContext _context;

        public DepartmentRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Departments>> GetAll()
        {
            return await _context.TblDepartment.ToListAsync();
        }

        public async Task<Departments> Get(string id)
        {
            return await _context.TblDepartment.FindAsync(id);
        }

        public async Task<Departments> Create(Departments _object)
        {
            _context.TblDepartment.Add(_object);
            await _context.SaveChangesAsync();
            return _object;
        }

        public async Task<Departments> Update(Departments _object)
        {
            _context.Entry(_object).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _object;
        }

        public async Task<bool> Delete(string id)
        {
            var data = await _context.TblDepartment.FindAsync(id);
            if (data == null)
            {
                return false;
            }

            _context.TblDepartment.Remove(data);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
