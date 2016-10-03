using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Repository.Entity;

namespace IndividualConsultationTool.Repository.Mappers
{
    public interface IMapper<TBusinessObject, TEntity> where TBusinessObject : IBusinessObject, new() where TEntity : IEntity
    {
        TBusinessObject MapToBusinessObject(TEntity entity);
        IEnumerable<TBusinessObject> MapToBusinessObjects(IEnumerable<TEntity> entities);
        TEntity MapToEntity(TBusinessObject businessModel);
    }
}
