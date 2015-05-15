// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jan-2012, 04:37:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisition_Detailed
    {

        public FCCREQRequisition_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisition_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisition_DetailedFacade facade = context.Items["IREQRequisition_DetailedFacade"] as Bay.ERP.BusinessFacade.IREQRequisition_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisition_DetailedFacade();
                context.Items["IREQRequisition_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
