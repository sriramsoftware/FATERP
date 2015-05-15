// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMFinancialStrengthMajorWork
    {

        public FCCCMFinancialStrengthMajorWork()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMFinancialStrengthMajorWorkFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMFinancialStrengthMajorWorkFacade facade = context.Items["ICMFinancialStrengthMajorWorkFacade"] as Bay.ERP.BusinessFacade.ICMFinancialStrengthMajorWorkFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMFinancialStrengthMajorWorkFacade();
                context.Items["ICMFinancialStrengthMajorWorkFacade"] = facade;
            }
            return facade;
        }


    }
}
