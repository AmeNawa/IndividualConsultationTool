using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using IndividualConsultationTool.Repository.BusinessObjects;
using IndividualConsultationTool.Repository.Mappers;
using IndividualConsultationTool.Repository.Mappers.AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IndividualConsultationTool.Tests.RepositoryTests.MapperTests.AutoMapperTests
{
    [TestClass]
    public class ConsultationMapperTests
    {
        [TestMethod]
        public void PassWhenConsultationMapToBOSucess()
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
        public void PassWhenConsultationMapToEntitySucess()
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


        private IMapper<Consultation, Repository.Entity.Consultation> getTarget()
        {
            return new ConsultationMapper();
        }


        private Repository.Entity.Consultation getEntity()
        {
            return new Repository.Entity.Consultation();
        }


        private Consultation getModel()
        {
            return new Consultation();
        }
    }
}
