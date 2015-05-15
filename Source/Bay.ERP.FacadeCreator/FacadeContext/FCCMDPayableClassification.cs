// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDPayableClassification
    {

        public FCCMDPayableClassification()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDPayableClassificationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDPayableClassificationFacade facade = context.Items["IMDPayableClassificationFacade"] as Bay.ERP.BusinessFacade.IMDPayableClassificationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDPayableClassificationFacade();
                context.Items["IMDPayableClassificationFacade"] = facade;
            }
            return facade;
        }


    }
}
