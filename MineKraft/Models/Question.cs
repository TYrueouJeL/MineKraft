using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineKraft.DbLib.Models
{
    internal class Question : IdentityObject
    {
        public string QuestionToAsk { get; set; }

        public HashSet<string> PossibleAnswers { get; set; }

        public HashSet<string> ValidAnswers { get; set; }

        [ForeignKey(nameof(Question.Topic))]
        public int TopicId { get; set; }

        public Topic Topic { get; set; }
    }
}
