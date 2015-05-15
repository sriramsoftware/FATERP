// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPFeedback
    {

        public FCCAPFeedback()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPFeedbackFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPFeedbackFacade facade = context.Items["IAPFeedbackFacade"] as Bay.ERP.BusinessFacade.IAPFeedbackFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APFeedbackFacade();
                context.Items["IAPFeedbackFacade"] = facade;
            }
            return facade;
        }


    }
}
