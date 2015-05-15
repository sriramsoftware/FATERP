// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:49:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCASPNETUserNameByMemberID
    {

        public FCCASPNETUserNameByMemberID()
        {

        }

        public static Bay.ERP.BusinessFacade.IASPNETUserNameByMemberIDFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IASPNETUserNameByMemberIDFacade facade = context.Items["IASPNETUserNameByMemberIDFacade"] as Bay.ERP.BusinessFacade.IASPNETUserNameByMemberIDFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ASPNETUserNameByMemberIDFacade();
                context.Items["IASPNETUserNameByMemberIDFacade"] = facade;
            }
            return facade;
        }


    }
}
