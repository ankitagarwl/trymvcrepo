using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IStoreMaster
    {
        List<StoreMaster> GetStoreList(string PageSize, string CurrentPage);
        bool SaveDocument(StoreMaster storemaster);
        bool DeleteDocument(int StoreId);
        bool UpdateDocument(StoreMaster storemaster);
        StoreMaster Getstore(int Id);
    }
}
