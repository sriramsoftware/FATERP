// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2013, 01:42:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCRMAgreement_Detailed
    {

        public FCCCRMAgreement_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.ICRMAgreement_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICRMAgreement_DetailedFacade facade = context.Items["ICRMAgreement_DetailedFacade"] as Bay.ERP.BusinessFacade.ICRMAgreement_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CRMAgreement_DetailedFacade();
                context.Items["ICRMAgreement_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}