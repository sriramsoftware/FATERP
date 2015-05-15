// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMSurveyOwner
    {

        public FCCCRMSurveyOwner()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMSurveyOwnerFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMSurveyOwnerFacade facade = context.Items["ICRMSurveyOwnerFacade"] as Bay.ERP.BusinessFacade.ICRMSurveyOwnerFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMSurveyOwnerFacade();
                context.Items["ICRMSurveyOwnerFacade"] = facade;
            }
            return facade;
        }


    }
}
