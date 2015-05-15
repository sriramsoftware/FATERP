// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 05:41:06




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRGenerateEvaluation_Custom
    {

        public FCCHRGenerateEvaluation_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRGenerateEvaluation_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRGenerateEvaluation_CustomFacade facade = context.Items["IHRGenerateEvaluation_CustomFacade"] as Bay.ERP.BusinessFacade.IHRGenerateEvaluation_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRGenerateEvaluation_CustomFacade();
                context.Items["IHRGenerateEvaluation_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
