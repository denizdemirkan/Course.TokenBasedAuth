using Course.TokenBasedAuth.SharedLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.TokenBasedAuth.Core.Services
{
    // Service layer "takes Entity" and "returns DTO as a Responce"
    public interface IGenericService<TEntity,TDto> where TEntity : class where TDto : class
    {
        Task<ResponceDTO<TDto>> GetByIdAsync(int Id);
        Task<ResponceDTO<IEnumerable<TDto>>> GetAllAsync();
        Task<ResponceDTO<TDto>> CreateAsync(TEntity entity);
        Task<ResponceDTO<NoDataDTO>> RemoveAsync(TEntity entity);
        Task<ResponceDTO<TDto>> UpdateAsync(TEntity entity);
    }
}
