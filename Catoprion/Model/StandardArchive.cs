using Piranha.Models;

namespace Catoprion
{
    public class StandardArchive : Page<StandardArchive>
    {
        public PostArchive<PostInfo> Archive { get; set; }
    }
    
}