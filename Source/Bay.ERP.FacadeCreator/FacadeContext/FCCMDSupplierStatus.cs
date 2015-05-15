// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDSupplierStatus
    {

        public FCCMDSupplierStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDSupplierStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDSupplierStatusFacade facade = context.Items["IMDSupplierStatusFacade"] as Bay.ERP.BusinessFacade.IMDSupplierStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDSupplierStatusFacade();
                context.Items["IMDSupplierStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
