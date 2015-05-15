// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:06:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRWorkingDay_RPT
    {

        public FCCHRWorkingDay_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRWorkingDay_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRWorkingDay_RPTFacade facade = context.Items["IHRWorkingDay_RPTFacade"] as Bay.ERP.BusinessFacade.IHRWorkingDay_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRWorkingDay_RPTFacade();
                context.Items["IHRWorkingDay_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
