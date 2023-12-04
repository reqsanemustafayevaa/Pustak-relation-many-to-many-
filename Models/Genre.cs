namespace MVC_project_crud_fileupload.Models
{
    public class Genre:BaseEntity  //genre-book one to many
    {
        public string Name {  get; set; }   
        public List<Book>? Books { get; set; }
    }
}
