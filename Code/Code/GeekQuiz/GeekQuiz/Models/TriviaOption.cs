using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekQuiz.Models
{
    public class TriviaOption
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TriviaQuestion")]
        public int QuestionId { get; set; }
        public virtual TriviaQuestion TriviaQuestion { get; set; }

        [Required]
        public string Title { get; set; }

        public bool IsCorrect { get; set; }
    }
}
