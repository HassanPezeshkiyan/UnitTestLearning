using System.ComponentModel.DataAnnotations;

namespace DB
{
    public class ProjectEntity
    {
        public ProjectEntity(int id, string title, string description)
        {
            this.Title = title; 
            this.Description = description;
            this.CreationDate= DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}