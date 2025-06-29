
using Microsoft.EntityFrameworkCore;
using Project.DotNet.Api.DAL;

namespace Project.DotNet.Api.Repositories;

public class CommonRepository<T> : ICommonRepository<T> where T : class
{
    private readonly DotNetDbContext _context;

    public CommonRepository(DotNetDbContext context)
    {
        _context = context;
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetDetailsAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<int> InsertAsync(T item)
    {
        await _context.Set<T>().AddAsync(item);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateAsync(T item)
    {
        _context.Entry(item).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }
    public async Task<int> DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity == null)
        {
            return 0;
        }
        _context.Set<T>().Remove(entity);
        return await _context.SaveChangesAsync();
    }
}
