﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using IndividualConsultationTool.Repository.BusinessObjects;

namespace IndividualConsultationTool.Repository.Mappers.AutoMapper
{
    public class AdressMapper : IMapper<Adress, Entity.Adress>
    {
        /// <summary>
        /// Initialize mapper
        /// </summary>
        public AdressMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entity.Adress, Adress>();
                cfg.CreateMap<Entity.Cabinet, Cabinet>();

                cfg.CreateMap<Adress, Entity.Adress>();
                cfg.CreateMap<Cabinet, Entity.Cabinet>();
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Adress MapToBusinessObject(Entity.Adress entity)
        {
            return Mapper.Map<Adress>(entity);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public IEnumerable<Adress> MapToBusinessObjects(IEnumerable<Entity.Adress> entities)
        {
            return Mapper.Map<IEnumerable<Adress>>(entities);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="businessModel"></param>
        /// <returns></returns>
        public Entity.Adress MapToEntity(Adress businessModel)
        {
            return Mapper.Map<Entity.Adress>(businessModel);
        }
    }
}
