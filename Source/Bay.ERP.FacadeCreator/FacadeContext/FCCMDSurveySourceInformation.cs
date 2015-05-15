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
    public class FCCMDSurveySourceInformation
    {

        public FCCMDSurveySourceInformation()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDSurveySourceInformationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDSurveySourceInformationFacade facade = context.Items["IMDSurveySourceInformationFacade"] as Bay.ERP.BusinessFacade.IMDSurveySourceInformationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDSurveySourceInformationFacade();
                context.Items["IMDSurveySourceInformationFacade"] = facade;
            }
            return facade;
        }


    }
}
