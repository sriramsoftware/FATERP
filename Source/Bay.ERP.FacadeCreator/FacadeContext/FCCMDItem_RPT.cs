// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 12:40:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDItem_RPT
    {

        public FCCMDItem_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDItem_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDItem_RPTFacade facade = context.Items["IMDItem_RPTFacade"] as Bay.ERP.BusinessFacade.IMDItem_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDItem_RPTFacade();
                context.Items["IMDItem_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
