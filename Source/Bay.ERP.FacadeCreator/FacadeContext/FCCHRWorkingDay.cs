// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 03:14:39




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRWorkingDay
    {

        public FCCHRWorkingDay()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRWorkingDayFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRWorkingDayFacade facade = context.Items["IHRWorkingDayFacade"] as Bay.ERP.BusinessFacade.IHRWorkingDayFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRWorkingDayFacade();
                context.Items["IHRWorkingDayFacade"] = facade;
            }
            return facade;
        }


    }
}
