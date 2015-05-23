using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekQuiz.Models
{    
    public class TriviaQuestion
    {
         [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required (ErrorMessage="Question title cannot be blank.")]
        public string Title { get; set; }

        public virtual List<TriviaOption> Options { get; set; }
    }

}
