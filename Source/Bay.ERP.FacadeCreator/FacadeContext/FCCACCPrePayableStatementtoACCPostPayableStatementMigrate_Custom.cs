// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 01:14:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom
    {

        public FCCACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade facade = context.Items["IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade"] as Bay.ERP.BusinessFacade.IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade();
                context.Items["IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}
