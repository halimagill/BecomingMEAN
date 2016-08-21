using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoRepository;

namespace TurnerBroadcasting.Repository
{
    public class TitleRepository
    {
        private static MongoRepository<Title> titleRepo = new MongoRepository<Title>();

        public static IEnumerable<Title> GetAllTitles()
        {
            IEnumerable<Title> titlesList = new List<Title>();

            titlesList = titleRepo.Select(t => t).ToList<Title>().AsEnumerable<Title>();
            return titlesList;
        }

        public static IEnumerable<Title> FindTitleByName(string name)
        { 
            IEnumerable<Title> titlesList = new List<Title>();
            titlesList = titleRepo.Where(t => t.TitleName.ToLower().Contains(name.ToLower())).ToList().AsEnumerable();

            return titlesList;
        }

        public static Title FindTitleById(int id)
        {
            var title = titleRepo.Where(t => t.TitleId == id).SingleOrDefault();

            return title;
        }
    }
}
