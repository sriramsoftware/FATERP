// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 02:55:23




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACAccountGroupBalanceSheet_Custom
    {

        public FCCACAccountGroupBalanceSheet_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACAccountGroupBalanceSheet_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACAccountGroupBalanceSheet_CustomFacade facade = context.Items["IACAccountGroupBalanceSheet_CustomFacade"] as Bay.ERP.BusinessFacade.IACAccountGroupBalanceSheet_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACAccountGroupBalanceSheet_CustomFacade();
                context.Items["IACAccountGroupBalanceSheet_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
