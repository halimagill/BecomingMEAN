using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnerBroadcasting.Repository
{
    public interface ITitleRepository
    {
        IEnumerable<Title> GetAllTitles();
    }
}
