using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyKTV.KTVEntity
{
    [Table("SearchCache")]
    public class SearchCache
    {
        [Key]
        public string SearchName { get; set; }

        public string SearchContent { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
