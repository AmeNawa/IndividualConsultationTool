﻿using System;
using System.Collections.Generic;
using System.Linq;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Repository.Mappers;
using IndividualConsultationTool.Repository.Mappers.AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndividualConsultationTool.Tests.RepositoryTests.MapperTests.AutoMapperTests
{
    [TestClass]
    public class AdressMapperTests
    {
        [TestMethod]
        public void PassWhenAdressMapToBOSucess()
        {
            // Arrange
            var target = getTarget();
            var entity = getEntity();
            var id = 10;
            entity.Id = id;

            // Act
            var model = target.MapToBusinessObject(entity);

            // Assert
            Assert.AreEqual(id, model.Id);
        }


        [TestMethod]
        public void PassWhenAdressMapToEntitySucess()
        {
            // Arrange
            var target = getTarget();
            var model = getModel();
            var id = 10;
            model.Id = id;

            // Act
            var entity = target.MapToEntity(model);

            // Assert
            Assert.AreEqual(id, entity.Id);
        }


        private IMapper<Adress, Repository.Entity.Adress> getTarget()
        {
            return new AdressMapper();
        }


        private Repository.Entity.Adress getEntity()
        {
            return new Repository.Entity.Adress();
        }


        private Adress getModel()
        {
            return  new Adress();
        }
    }
}
