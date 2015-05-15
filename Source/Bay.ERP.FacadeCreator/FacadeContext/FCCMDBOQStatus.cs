// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDBOQStatus
    {

        public FCCMDBOQStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDBOQStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDBOQStatusFacade facade = context.Items["IMDBOQStatusFacade"] as Bay.ERP.BusinessFacade.IMDBOQStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDBOQStatusFacade();
                context.Items["IMDBOQStatusFacade"] = facade;
            }
            return facade;
        }


    }
}