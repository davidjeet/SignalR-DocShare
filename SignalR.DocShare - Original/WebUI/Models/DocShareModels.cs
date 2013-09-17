using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{   
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Content")]
        public string DocumentBody { get; set; }
    } 

}