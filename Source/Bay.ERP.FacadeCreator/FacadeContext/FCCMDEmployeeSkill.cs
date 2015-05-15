// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDEmployeeSkill
    {

        public FCCMDEmployeeSkill()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDEmployeeSkillFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDEmployeeSkillFacade facade = context.Items["IMDEmployeeSkillFacade"] as Bay.ERP.BusinessFacade.IMDEmployeeSkillFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDEmployeeSkillFacade();
                context.Items["IMDEmployeeSkillFacade"] = facade;
            }
            return facade;
        }


    }
}
