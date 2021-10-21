﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicinestockRepository : IMedicinestockRepository
    {
        MedicineStockContext dbContext = new MedicineStockContext();

        public async Task<List<MedicineStock>> GetMedicineStocks()
        {
            List<MedicineStock> stock = new List<MedicineStock>();
            try
            {
                return await dbContext.MedicineStocks.ToListAsync();
            }
            catch (Exception)
            {
                throw new MedicineStockException(" Medicine Out Of Stock ");
            }
        }

    }
}
