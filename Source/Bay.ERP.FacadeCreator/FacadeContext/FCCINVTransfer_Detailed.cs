// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Dec-2012, 02:15:29




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTransfer_Detailed
    {

        public FCCINVTransfer_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransfer_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransfer_DetailedFacade facade = context.Items["IINVTransfer_DetailedFacade"] as Bay.ERP.BusinessFacade.IINVTransfer_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransfer_DetailedFacade();
                context.Items["IINVTransfer_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
