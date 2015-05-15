// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2013, 04:38:22




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACProjectWiseAccount_Custom
    {

        public FCCACProjectWiseAccount_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACProjectWiseAccount_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACProjectWiseAccount_CustomFacade facade = context.Items["IACProjectWiseAccount_CustomFacade"] as Bay.ERP.BusinessFacade.IACProjectWiseAccount_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACProjectWiseAccount_CustomFacade();
                context.Items["IACProjectWiseAccount_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
