// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2012, 11:09:39




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCUserList_Detailed
    {

        public FCCUserList_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IUserList_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IUserList_DetailedFacade facade = context.Items["IUserList_DetailedFacade"] as Bay.ERP.BusinessFacade.IUserList_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.UserList_DetailedFacade();
                context.Items["IUserList_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
