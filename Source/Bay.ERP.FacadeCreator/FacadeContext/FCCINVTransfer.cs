// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jun-2013, 01:46:16




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTransfer
    {

        public FCCINVTransfer()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTransferFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTransferFacade facade = context.Items["IINVTransferFacade"] as Bay.ERP.BusinessFacade.IINVTransferFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTransferFacade();
                context.Items["IINVTransferFacade"] = facade;
            }
            return facade;
        }


    }
}
