namespace MVC_project_crud_fileupload.Models
{
    public class Tag:BaseEntity   //Tag-Book many-to-many
    {   

        public  string Name {  get; set; }
        public List<BookTag>?BookTags { get; set; }
    }
}
