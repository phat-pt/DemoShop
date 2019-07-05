﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdateBy { get; set; }

        bool Status { get; set; }

        string MetaKeyWord { get; set; }

        string MetaDescription { get; set; }
    }
}
