// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2013, 12:02:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACAccountOpenCloseBalance_Custom
    {

        public FCCACAccountOpenCloseBalance_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACAccountOpenCloseBalance_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACAccountOpenCloseBalance_CustomFacade facade = context.Items["IACAccountOpenCloseBalance_CustomFacade"] as Bay.ERP.BusinessFacade.IACAccountOpenCloseBalance_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACAccountOpenCloseBalance_CustomFacade();
                context.Items["IACAccountOpenCloseBalance_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
