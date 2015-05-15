// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2012, 04:28:13




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPreBOQtoBOQMigration_Custom
    {

        public FCCPreBOQtoBOQMigration_Custom()
        {

        }

        public static Bay.ERP.BusinessFacade.IPreBOQtoBOQMigration_CustomFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPreBOQtoBOQMigration_CustomFacade facade = context.Items["IPreBOQtoBOQMigration_CustomFacade"] as Bay.ERP.BusinessFacade.IPreBOQtoBOQMigration_CustomFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PreBOQtoBOQMigration_CustomFacade();
                context.Items["IPreBOQtoBOQMigration_CustomFacade"] = facade;
            }
            return facade;
        }


    }
}