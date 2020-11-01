using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungShop.Model.Abstract
{
    public interface IAudittable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set;}
        string UpdatedBy { get; set; }
        bool Status { get; set;}
        string Metakeyword { get; set; }
        string MetaDescription { get; set; }

    }
}
