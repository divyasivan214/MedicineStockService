using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicinestockService:IMedicinestockService
    {
        MedicinestockRepository repoObj = new MedicinestockRepository();
        public async Task<List<MedicineStock>> GetAllStocks()
        {
            
            return await repoObj.GetMedicineStocks();
        }
    }
}
