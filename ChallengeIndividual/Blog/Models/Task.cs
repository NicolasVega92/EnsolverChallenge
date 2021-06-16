using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoMVC.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(75, ErrorMessage ="El contenido debe tener menos de 75 letras")]
        [DisplayName("Contenido")]
        [Required]
        public string Content { get; set; }

        [DisplayName("Carpeta")]
        [Range(1, 10)]
        [Required]
        //public virtual List<Category> Categories { get; set; }
        public int FolderId { get; set; }
        public virtual Folder Folder { get; set; }
    }
}
