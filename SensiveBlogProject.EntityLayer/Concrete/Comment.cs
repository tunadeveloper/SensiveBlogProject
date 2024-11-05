using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlogProject.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Detail { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
