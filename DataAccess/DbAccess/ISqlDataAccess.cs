using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    internal interface ISqlDataAccess
    {
        Task<List<T>> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName);
        Task SaveData<T>(string storedProcedure, T parameters, string connectionStringName);
        Task SaveListOfData<T>(string storedProcedure, List<T> ClassList, string connectionStringName);
    }
}
