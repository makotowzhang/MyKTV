using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTV.KTVModel
{
    public class KTVQueue
    {
        public bool IsPlaying { get; set; }
        
        public int Sort { get; set; }
        
        public MTVInfo MTV { get; set; }
    }
}
