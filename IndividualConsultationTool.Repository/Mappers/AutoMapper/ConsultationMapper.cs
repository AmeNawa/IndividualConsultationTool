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
    public class ConsultationMapper : IMapper<Consultation, Entity.Consultation>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public ConsultationMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Consultation, Consultation>();
                cfg.CreateMap<Entity.Cabinet, Cabinet>();
                cfg.CreateMap<Entity.Facture, Facture>();
                cfg.CreateMap<Entity.ConsultationChain, ConsultationChain>();
                cfg.CreateMap<Entity.Patient, Patient>();

                cfg.CreateMap<Consultation, Entity.Consultation>();
                cfg.CreateMap<Cabinet, Entity.Cabinet>();
                cfg.CreateMap<Facture, Entity.Facture>();
                cfg.CreateMap<ConsultationChain, Entity.ConsultationChain>();
                cfg.CreateMap<Patient, Entity.Patient>();
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Consultation MapToBusinessObject(Entity.Consultation entity)
        {
            return Mapper.Map<Consultation>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Consultation> MapToBusinessObjects(IEnumerable<Entity.Consultation> entities)
        {
            return Mapper.Map<IEnumerable<Consultation>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Consultation MapToEntity(Consultation businessModel)
        {
            return Mapper.Map<Entity.Consultation>(businessModel);
        }
    }
}
