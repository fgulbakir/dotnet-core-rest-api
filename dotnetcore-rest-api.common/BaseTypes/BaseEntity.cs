using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore_rest_api.common.BaseTypes
{
    public class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public int? Creator { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? Modifier { get; set; }
        public bool IsDeleted { get; set; }
    }
}
