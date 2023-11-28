using System.ComponentModel.DataAnnotations;

namespace practice3.Model
{
    public class Subjects
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int StudentId { get; set; }
      
        public string ? StudentName { get; set; }

        public int SubjectId { get; set; }
        public string ? SubjectName { get; set;}
        public string ? SubjectMark { get; set; }

    }
}
