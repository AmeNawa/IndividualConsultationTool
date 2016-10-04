using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Repository;
using AutoMapper;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class CabinetMapper : IMapper<Cabinet, Entity.Cabinet>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public CabinetMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Cabinet, Cabinet>();
                cfg.CreateMap<Entity.Doctor, Doctor>();
                cfg.CreateMap<Entity.Adress, Adress>();
                cfg.CreateMap<Entity.Consultation, Consultation>();

                cfg.CreateMap<Cabinet, Entity.Cabinet>();
                cfg.CreateMap<Doctor, Entity.Doctor>();
                cfg.CreateMap<Adress, Entity.Adress>();
                cfg.CreateMap<Consultation, Entity.Consultation>();
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Cabinet MapToBusinessObject(Entity.Cabinet entity)
        {
            return Mapper.Map<Cabinet>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Cabinet> MapToBusinessObjects(IEnumerable<Entity.Cabinet> entities)
        {
            return Mapper.Map<List<Cabinet>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Cabinet MapToEntity(Cabinet businessModel)
        {
            return Mapper.Map<Entity.Cabinet>(businessModel);
        }
    }
}