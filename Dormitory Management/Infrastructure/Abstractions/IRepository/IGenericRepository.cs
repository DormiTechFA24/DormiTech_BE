using Application.Utils;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infractstructure.Abstractions.IRepository
{
    //Dùng cho cho các CRUD cơ bản
    public interface IGenericRepository<TModel> where TModel : class
    {
        // Get All
        Task<List<TModel>> GetAllAsync();
        // Get all với Filter
        Task<List<TModel>> GetAllAsync(Func<IQueryable<TModel>, IIncludableQueryable<TModel, object>>? include = null);
        //Get by id
        Task<TModel?> GetByIdAsync(int id);
        //Thêm
        Task AddAsync(TModel model);
        //Sửa
        void Update(TModel model);

        //Phân trang
        Task<Paginations<TModel>> ToPaginationAsync(int pageIndex = 0, int pageSize = 10);
        //Xoá
        Task<bool> DeleteAsync(TModel model);

    }
}
