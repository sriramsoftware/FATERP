// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Sep-2012, 12:46:09




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDDMSOwnerType
    {

        public FCCMDDMSOwnerType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDDMSOwnerTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDDMSOwnerTypeFacade facade = context.Items["IMDDMSOwnerTypeFacade"] as Bay.ERP.BusinessFacade.IMDDMSOwnerTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDDMSOwnerTypeFacade();
                context.Items["IMDDMSOwnerTypeFacade"] = facade;
            }
            return facade;
        }


    }
}
