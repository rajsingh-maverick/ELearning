using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ELearning.Web.API
{
    public class QuestionController : ApiController
    {
        // GET api/question
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/question/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/question
        public void Post([FromBody]string value)
        {
        }

        // PUT api/question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/question/5
        public void Delete(int id)
        {
        }
    }
}
