using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBS.Infrastructure.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string CommentLine { get; set; }
    }
}
