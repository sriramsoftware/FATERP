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
    public class FCCCRMSurveyMaster
    {

        public FCCCRMSurveyMaster()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMSurveyMasterFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMSurveyMasterFacade facade = context.Items["ICRMSurveyMasterFacade"] as Bay.ERP.BusinessFacade.ICRMSurveyMasterFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMSurveyMasterFacade();
                context.Items["ICRMSurveyMasterFacade"] = facade;
            }
            return facade;
        }


    }
}
