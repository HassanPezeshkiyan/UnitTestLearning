using DB;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;

namespace Project.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]

    public class ProjectController : ControllerBase
    {

        private readonly AppDbContext? db;
        List<ProjectEntity> projects = new List<ProjectEntity>();

        public ProjectController(List<ProjectEntity> projects)
        {
            this.projects = projects;
        }

        public ProjectController(List<ProjectEntity> projects, AppDbContext db)
        {
            this.projects = projects;
            this.db = db;
        }
       
        [HttpGet]
        public IEnumerable<ProjectEntity> GetAllProjectEntitys()
        {
            return db.Projects.ToList();
        }
        
        
        [HttpGet("{id}")]
        public IHttpActionResult GetProjectEntity(int id)
        {
            var project = db.Projects.FirstOrDefault((p) => p.Id == id);
            if (project == null)
            {
                return (System.Web.Http.IHttpActionResult)NotFound();
            }
            return (System.Web.Http.IHttpActionResult)Ok(project);
        }


    }
}
