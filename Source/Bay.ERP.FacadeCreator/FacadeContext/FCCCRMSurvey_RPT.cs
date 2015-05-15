// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMSurvey_RPT
    {

        public FCCCRMSurvey_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMSurvey_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMSurvey_RPTFacade facade = context.Items["ICRMSurvey_RPTFacade"] as Bay.ERP.BusinessFacade.ICRMSurvey_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMSurvey_RPTFacade();
                context.Items["ICRMSurvey_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
