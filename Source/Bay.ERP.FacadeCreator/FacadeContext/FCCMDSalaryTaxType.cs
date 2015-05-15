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
    public class FCCMDSalaryTaxType
    {

        public FCCMDSalaryTaxType()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDSalaryTaxTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDSalaryTaxTypeFacade facade = context.Items["IMDSalaryTaxTypeFacade"] as Bay.ERP.BusinessFacade.IMDSalaryTaxTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDSalaryTaxTypeFacade();
                context.Items["IMDSalaryTaxTypeFacade"] = facade;
            }
            return facade;
        }


    }
}