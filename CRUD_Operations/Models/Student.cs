using System.ComponentModel.DataAnnotations;

namespace CRUD_Operations.Models
{
    public class Student
    {
        [Key]
        public int StudentId
        {
            get;
            set;
        }
        public string Nume
        {
            get;
            set;
        }
        public string Prenume
        {
            get;
            set;
        }
        public string Grupa
        {
            get;
            set;
        }
    }
}
