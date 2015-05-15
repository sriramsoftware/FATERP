// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDArtGalleriaLocation
    {

        public FCCMDArtGalleriaLocation()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDArtGalleriaLocationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDArtGalleriaLocationFacade facade = context.Items["IMDArtGalleriaLocationFacade"] as Bay.ERP.BusinessFacade.IMDArtGalleriaLocationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDArtGalleriaLocationFacade();
                context.Items["IMDArtGalleriaLocationFacade"] = facade;
            }
            return facade;
        }


    }
}