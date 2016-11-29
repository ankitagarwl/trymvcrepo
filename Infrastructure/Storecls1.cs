using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Infrastructure
{
    class Storecls1 : IStoreMaster
    {
        public bool DeleteDocument(int StoreId)
        {
            throw new NotImplementedException();
        }

        public StoreMaster Getstore(int Id)
        {
            using (trymvc1DataContext context = new trymvc1DataContext())
            {
                StoreMaster storemaster = context.StoreMasters.Where(x => x.id == Id).FirstOrDefault();
                return storemaster;
            }
        }

        public List<StoreMaster> GetStoreList(string PageSize, string CurrentPage)
        {
            throw new NotImplementedException();
        }

        public bool SaveDocument(StoreMaster storemaster)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDocument(StoreMaster storemaster)
        {
            throw new NotImplementedException();
        }
    }
}
