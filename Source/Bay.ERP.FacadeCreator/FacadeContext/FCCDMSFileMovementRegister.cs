// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCDMSFileMovementRegister
    {

        public FCCDMSFileMovementRegister()
        {

        }

        public static Bay.ERP.BusinessFacade.IDMSFileMovementRegisterFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IDMSFileMovementRegisterFacade facade = context.Items["IDMSFileMovementRegisterFacade"] as Bay.ERP.BusinessFacade.IDMSFileMovementRegisterFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.DMSFileMovementRegisterFacade();
                context.Items["IDMSFileMovementRegisterFacade"] = facade;
            }
            return facade;
        }


    }
}
