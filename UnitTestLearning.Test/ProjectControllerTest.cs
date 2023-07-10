using DB;
using Microsoft.AspNetCore.Http.HttpResults;
using Project.Controllers;
using System.Web.Http.Results;
using Xunit.Sdk;

namespace UnitTestLearning.Test
{
    [TestClass]
    public class ProjectControllerTest
    {

        [TestMethod]
        public void GetAllProjectEntitys_ShouldReturnAllProjectEntitys()
        {

            var testProjects = GetTestProjects();
            var controller = new ProjectController(testProjects);

            var result = controller.GetAllProjectEntitys() as List<ProjectEntity>;
            Assert.AreEqual(testProjects.Count, result.Count);
        }

        [TestMethod]
        public void GetProjectEntity_ShouldReturnCorrectProjectEntity()
        {
            var testProjects = GetTestProjects();
            var controller = new ProjectController(testProjects);

            var result = controller.GetProjectEntity(4) as OkNegotiatedContentResult<ProjectEntity>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testProjects[3].Title, result.Content.Title);
        }



        [TestMethod]
        public void GetProjectEntity_ShouldNotFindProjectEntity()
        {
            var controller = new ProjectController(GetTestProjects());
            var result = controller.GetProjectEntity(999);
            Assert.IsInstanceOfType(result, typeof(NotFound<ProjectEntity>));
        }

        private List<ProjectEntity> GetTestProjects()
        {
            var testProject = new List<ProjectEntity>();
            testProject.Add(new ProjectEntity(id: 1, title: "Demo1", description: "test description for project 1"));
            testProject.Add(new ProjectEntity(id: 2, title: "Demo2", description: "test description for project 2"));
            testProject.Add(new ProjectEntity(id: 3, title: "Demo3", description: "test description for project 3"));
            testProject.Add(new ProjectEntity(id: 4, title: "Demo4", description: "test description for project 4"));
            return testProject;
        }

    }
}