using Microsoft.EntityFrameworkCore;
using vShop.ProductApi.Context;
using vShop.ProductApi.Domain.Models;
using vShop.ProductApi.Domain.Repository.Interfaces;

namespace vShop.ProductApi.Domain.Repository.Implementation;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    public ProductRepository(AppDbContext context)
    {
        this._context = context;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
        var products = await _context.Products.AsNoTracking().Include(c => c.Category).ToListAsync();
        return products;
    }

    public async Task<Product> GetById(int id)
    {
        return await _context.Products.Include(c => c.Category).Where(p => p.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Product> Create(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> Update(Product product)
    {
        _context.Entry(product).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return product;
    }
    public async Task<Product> Delete(int id)
    {
        var product = await GetById(id);
        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
        return product;
    }
}
