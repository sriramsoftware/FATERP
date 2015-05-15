// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Apr-2013, 04:34:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMCommunication_Detailed
    {

        public FCCCRMCommunication_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMCommunication_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMCommunication_DetailedFacade facade = context.Items["ICRMCommunication_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMCommunication_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMCommunication_DetailedFacade();
                context.Items["ICRMCommunication_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
