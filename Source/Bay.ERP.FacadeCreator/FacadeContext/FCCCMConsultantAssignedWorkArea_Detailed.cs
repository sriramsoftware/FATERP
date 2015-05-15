// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 11:59:55




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantAssignedWorkArea_Detailed
    {

        public FCCCMConsultantAssignedWorkArea_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkArea_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkArea_DetailedFacade facade = context.Items["ICMConsultantAssignedWorkArea_DetailedFacade"] as Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkArea_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantAssignedWorkArea_DetailedFacade();
                context.Items["ICMConsultantAssignedWorkArea_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
