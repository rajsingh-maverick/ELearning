using ELearning.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Model.Poco
{
    public class Question
    {
        public Question()
        {
            Options = new List<Option>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string QuestionText { get; set; }

        public string Description { get; set; }
        public Level Level { get; set; }
        public QuestionType Type { get; set; }
        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Option> Options { get; set; }
        
    }
}
