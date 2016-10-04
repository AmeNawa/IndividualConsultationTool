using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Common.Secure;
using Ninject;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class PatientMapper : IMapper<Patient, Entity.Patient>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public PatientMapper()
        {
            var kernel = Common.Infrastructure.Factory.GetInstance();
            var AES = kernel.Get<ICrypt>();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Patient, Patient>();
                cfg.CreateMap<Entity.Contact, Contact>();
                cfg.CreateMap<Entity.ConsultationChain, ConsultationChain>();

                cfg.CreateMap<Patient, Entity.Patient>();
                cfg.CreateMap<Contact, Entity.Contact>();
                cfg.CreateMap<ConsultationChain, Entity.ConsultationChain>();
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Patient MapToBusinessObject(Entity.Patient entity)
        {
            return Mapper.Map<Patient>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Patient> MapToBusinessObjects(IEnumerable<Entity.Patient> entities)
        {
            return Mapper.Map<IEnumerable<Patient>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Patient MapToEntity(Patient businessModel)
        {
            return Mapper.Map<Entity.Patient>(businessModel);
        }
    }
}
