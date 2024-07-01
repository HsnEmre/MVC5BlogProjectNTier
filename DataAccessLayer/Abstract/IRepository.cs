using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {

        #region Listele
        List<T> List();
        #endregion
        #region ekle
        int Insert(T p);
        #endregion
        #region Güncelle
        int Update(T p);
        #endregion
        #region Sil
        int Delete(T p);
        #endregion

        #region GetId
        T GetByID(int id);
        #endregion


    }
}
