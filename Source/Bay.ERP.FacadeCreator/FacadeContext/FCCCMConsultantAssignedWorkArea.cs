// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMConsultantAssignedWorkArea
    {

        public FCCCMConsultantAssignedWorkArea()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkAreaFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkAreaFacade facade = context.Items["ICMConsultantAssignedWorkAreaFacade"] as Bay.ERP.BusinessFacade.ICMConsultantAssignedWorkAreaFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMConsultantAssignedWorkAreaFacade();
                context.Items["ICMConsultantAssignedWorkAreaFacade"] = facade;
            }
            return facade;
        }


    }
}
