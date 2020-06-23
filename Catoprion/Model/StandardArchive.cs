using Piranha.AttributeBuilder;
using Piranha.Models;

namespace Catoprion
{
    [PageType(Title="Standard archive", IsArchive=true)]
    public class StandardArchive : Page<StandardArchive>
    {
        public PostArchive<PostInfo> Archive { get; set; }
    }
    
}