// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Sep-2012, 10:36:26




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCDMSFileMovementRegister_Detailed
    {

        public FCCDMSFileMovementRegister_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IDMSFileMovementRegister_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IDMSFileMovementRegister_DetailedFacade facade = context.Items["IDMSFileMovementRegister_DetailedFacade"] as Bay.ERP.BusinessFacade.IDMSFileMovementRegister_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.DMSFileMovementRegister_DetailedFacade();
                context.Items["IDMSFileMovementRegister_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
