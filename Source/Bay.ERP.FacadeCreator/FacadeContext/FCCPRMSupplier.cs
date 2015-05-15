// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-May-2012, 11:02:33




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMSupplier
    {

        public FCCPRMSupplier()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMSupplierFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMSupplierFacade facade = context.Items["IPRMSupplierFacade"] as Bay.ERP.BusinessFacade.IPRMSupplierFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMSupplierFacade();
                context.Items["IPRMSupplierFacade"] = facade;
            }
            return facade;
        }


    }
}
