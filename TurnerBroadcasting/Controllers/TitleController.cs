using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TurnerBroadcasting.Repository;

namespace TurnerBroadcasting.Controllers
{
    public class TitleController : ApiController
    {
        // GET api/values
        public IEnumerable<Title> GetTitles()
        {
            return TitleRepository.GetAllTitles();
        }

        // GET api/values/5
        public Title GetTitleById(int id)
        {
            return TitleRepository.FindTitleById(id);
        }

        // GET api/values/5
        public IEnumerable<Title> GetTitleByName(string name)
        {
            return TitleRepository.FindTitleByName(name);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }
    }
}