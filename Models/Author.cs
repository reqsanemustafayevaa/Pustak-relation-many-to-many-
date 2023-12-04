namespace MVC_project_crud_fileupload.Models
{
    public class Author:BaseEntity   //Author-Book  one to many
    {
        public string FullName { get; set; }
        public List<Book>? Books { get; set; }
    }
}
