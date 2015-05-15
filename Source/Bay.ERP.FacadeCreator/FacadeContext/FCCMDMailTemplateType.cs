// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Nov-2012, 10:24:47




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDMailTemplateType
    {

        public FCCMDMailTemplateType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDMailTemplateTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDMailTemplateTypeFacade facade = context.Items["IMDMailTemplateTypeFacade"] as Bay.ERP.BusinessFacade.IMDMailTemplateTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDMailTemplateTypeFacade();
                context.Items["IMDMailTemplateTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
