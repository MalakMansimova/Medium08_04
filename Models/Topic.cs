using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium08_05.Models
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentTopicId { get; set; }
    }
}
