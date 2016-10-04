using System;
using System.Collections.Generic;
using System.Linq;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Repository.Mappers;
using IndividualConsultationTool.Repository.Mappers.AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndividualConsultationTool.Tests.RepositoryTests.MapperTests.AutoMapperTests
{
    [TestClass]
    public class ConsultationChainMapperTests
    {
        [TestMethod]
        public void PassWhenConsultationChainMapToBOSucess()
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
        public void PassWhenConsultationChainMapToEntitySucess()
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


        private IMapper<ConsultationChain, Repository.Entity.ConsultationChain> getTarget()
        {
            return new ConsultationChainMapper();
        }


        private Repository.Entity.ConsultationChain getEntity()
        {
            return new Repository.Entity.ConsultationChain();
        }


        private ConsultationChain getModel()
        {
            return new ConsultationChain();
        }
    }
}
