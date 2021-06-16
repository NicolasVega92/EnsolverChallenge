using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Models
{
    public class Folder
    {
        [Key]
        public int IdFolder { get; set; }
        [DisplayName("Categoria")]
        [MaxLength(50, ErrorMessage ="El nombre de la carpeta debe ser menor a 50 letras")]
        [Required]
        public string FolderName { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}
