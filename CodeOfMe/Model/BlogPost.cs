using System.Collections.Generic;
using Piranha.AttributeBuilder;
using Piranha.Models;

namespace CodeOfMe.Model
{
    [PostType(Title = "Blog post")]
    public class BlogPost : Post<BlogPost>
    {
        public IEnumerable<Comment> Comments { get; set; } = new List<Comment>();

    }
    
}