using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BozkusMusic.Models
{
    public class SearchModel
    {
        public string Query { get; set; }
        public List<Video> Items { get; set; }
    }
}
