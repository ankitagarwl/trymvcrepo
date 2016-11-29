using Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    class StoreCls : IStoreMaster
    {

        bool IStoreMaster.DeleteDocument(int StoreId)
        {
            throw new NotImplementedException();
        }

        StoreMaster IStoreMaster.Getstore(int Id)
        {
            StoreMaster storemaster = new StoreMaster() { id=1, storename="sf" };
            return storemaster;
            //throw new NotImplementedException();
        }

        List<StoreMaster> IStoreMaster.GetStoreList(string PageSize, string CurrentPage)
        {
            throw new NotImplementedException();
        }

        bool IStoreMaster.SaveDocument(StoreMaster storemaster)
        {
            throw new NotImplementedException();
        }

        bool IStoreMaster.UpdateDocument(StoreMaster storemaster)
        {
            throw new NotImplementedException();
        }
    }
}
