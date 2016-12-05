using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAppCore.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string AndroidId { get; set; }
        public string FeedbackMessage { get; set; }
        public string EmailAddress { get; set; }

    }
}
