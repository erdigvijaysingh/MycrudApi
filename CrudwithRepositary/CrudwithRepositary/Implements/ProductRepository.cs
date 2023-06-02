using CrudwithRepositary.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudwithRepositary.Implements
{
    public class ProductRepository : IproductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<product>> GetAll()
        {
            var products = await _db.products.ToListAsync();
            return products;
        }

        public async Task<product> GetById(int id)
        {
            return await _db.products.FindAsync(id);
        }

        public async Task Add(product model)
        {

            await _db.products.AddAsync(model);
            _db.SaveChanges();


        }

        public async Task Update(product model)
        {
            var products = await _db.products.FindAsync(model.Id);
            if(products!=null)
            {
                products.ProductName = model.ProductName;
                products.Price = model.Price;
                products.Qty = model.Qty;
                _db.Update(products);
                await _db.SaveChangesAsync();
            }
            
            
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

       
        
    }
}
