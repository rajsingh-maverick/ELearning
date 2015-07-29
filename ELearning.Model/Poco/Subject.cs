using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELearning.Model.Poco
{
    public class Subject
    {
        public Subject()
        {
            Questions = new List<Question>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}
