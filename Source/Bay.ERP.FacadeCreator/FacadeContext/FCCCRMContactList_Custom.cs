// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:25:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMContactList_Custom
    {

        public FCCCRMContactList_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMContactList_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMContactList_CustomFacade facade = context.Items["ICRMContactList_CustomFacade"] as Bay.ERP.BusinessFacade.ICRMContactList_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMContactList_CustomFacade();
                context.Items["ICRMContactList_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
