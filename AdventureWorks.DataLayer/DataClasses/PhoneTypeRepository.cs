using Common.Library;
using AdventureWorks.EntityLayer;
using System.Collections.ObjectModel;

namespace AdventureWorks.DataLayer;

public partial class PhoneTypeRepository : IRepository<PhoneType>
{
    #region Get Method
    public ObservableCollection<PhoneType> Get()
    {
        return
            [
                new PhoneType 
                {
                    PhoneTypeId = 1,
                    TypeDescription = "Mobile"
                },
                new PhoneType 
                {
                    PhoneTypeId = 2,
                    TypeDescription = "Home"
                },
                new PhoneType
                {
                    PhoneTypeId = 3,
                    TypeDescription = "Other"
                }
            ];
    }
    #endregion

    #region Get(id) Method
    public PhoneType? Get(int id)
    {
        return Get().Where(row => row.PhoneTypeId == id).FirstOrDefault();
    }
    #endregion
}
