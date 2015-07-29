using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Model.Enums
{
    public enum Level : byte
    {
        Beginner,
        Intermediate,
        Expert
    }

    public enum QuestionType : byte
    {
        SingleChoice,
        MultipleChoice,
        LongAnswer
    }
}
