using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IndividualConsultationTool.Repository.BusinessObjects;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class FactureMapper : IMapper<Facture, Entity.Facture>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public FactureMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Facture, Facture>();
                cfg.CreateMap<Entity.Consultation, Consultation>();

                cfg.CreateMap<Facture, Entity.Facture>();
                cfg.CreateMap<Consultation, Entity.Consultation>();
            });
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Facture MapToBusinessObject(Entity.Facture entity)
        {
            return Mapper.Map<Facture>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Facture> MapToBusinessObjects(IEnumerable<Entity.Facture> entities)
        {
            return Mapper.Map<IEnumerable<Facture>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Facture MapToEntity(Facture businessModel)
        {
            return Mapper.Map<Entity.Facture>(businessModel);
        }
    }
}
