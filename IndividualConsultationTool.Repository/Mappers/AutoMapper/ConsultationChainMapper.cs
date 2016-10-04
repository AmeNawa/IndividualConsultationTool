using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Repository.BusinessObjects;
using AutoMapper;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class ConsultationChainMapper : IMapper<ConsultationChain, Entity.ConsultationChain>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public ConsultationChainMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.ConsultationChain, ConsultationChain>();

                cfg.CreateMap<ConsultationChain, Entity.ConsultationChain>();
            });
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public ConsultationChain MapToBusinessObject(Entity.ConsultationChain entity)
        {
            return Mapper.Map<ConsultationChain>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<ConsultationChain> MapToBusinessObjects(IEnumerable<Entity.ConsultationChain> entities)
        {
            return Mapper.Map<IEnumerable<ConsultationChain>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.ConsultationChain MapToEntity(ConsultationChain businessModel)
        {
            return Mapper.Map<Entity.ConsultationChain>(businessModel);
        }
    }
}
