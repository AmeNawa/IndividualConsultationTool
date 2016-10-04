using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualConsultationTool.Repository.BusinessObjects;
using AutoMapper;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class ContactMapper : IMapper<Contact, Entity.Contact>
    {
        public ContactMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Contact, Contact>();
                cfg.CreateMap<Entity.Doctor, Doctor>();
                cfg.CreateMap<Entity.Patient, Patient>();

                cfg.CreateMap<Contact, Entity.Contact>();
                cfg.CreateMap<Doctor, Entity.Doctor>();
                cfg.CreateMap<Patient, Entity.Patient>();
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Contact MapToBusinessObject(Entity.Contact entity)
        {
            return Mapper.Map<Contact>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Contact> MapToBusinessObjects(IEnumerable<Entity.Contact> entities)
        {
            return Mapper.Map<IEnumerable<Contact>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Contact MapToEntity(Contact businessModel)
        {
            return Mapper.Map<Entity.Contact>(businessModel);
        }
    }
}
