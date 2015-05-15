// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:39:02




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREvaluation_RPT
    {

        public FCCHREvaluation_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREvaluation_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREvaluation_RPTFacade facade = context.Items["IHREvaluation_RPTFacade"] as Bay.ERP.BusinessFacade.IHREvaluation_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREvaluation_RPTFacade();
                context.Items["IHREvaluation_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
