using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IndividualConsultationTool.Repository.BusinessObjects;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class DoctorMapper : IMapper<Doctor, Entity.Doctor>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public DoctorMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Doctor, Doctor>();
                cfg.CreateMap<Entity.Contact, Contact>();
                cfg.CreateMap<Entity.Cabinet, Cabinet>();

                cfg.CreateMap<Doctor, Entity.Doctor>();
                cfg.CreateMap<Contact, Entity.Contact>();
                cfg.CreateMap<Cabinet, Entity.Cabinet>();
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Doctor MapToBusinessObject(Entity.Doctor entity)
        {
            return Mapper.Map<Doctor>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Doctor> MapToBusinessObjects(IEnumerable<Entity.Doctor> entities)
        {
            return Mapper.Map<IEnumerable<Doctor>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Doctor MapToEntity(Doctor businessModel)
        {
            return Mapper.Map<Entity.Doctor>(businessModel);
        }
    }
}
