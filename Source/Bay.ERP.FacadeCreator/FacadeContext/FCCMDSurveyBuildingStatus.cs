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
    public class FCCMDSurveyBuildingStatus
    {

        public FCCMDSurveyBuildingStatus()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDSurveyBuildingStatusFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDSurveyBuildingStatusFacade facade = context.Items["IMDSurveyBuildingStatusFacade"] as Bay.ERP.BusinessFacade.IMDSurveyBuildingStatusFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDSurveyBuildingStatusFacade();
                context.Items["IMDSurveyBuildingStatusFacade"] = facade;
            }
            return facade;
        }


    }
}
