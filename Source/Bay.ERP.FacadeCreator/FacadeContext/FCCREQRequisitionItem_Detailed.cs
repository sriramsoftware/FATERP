// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 03:08:12




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItem_Detailed
    {

        public FCCREQRequisitionItem_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItem_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItem_DetailedFacade facade = context.Items["IREQRequisitionItem_DetailedFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItem_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItem_DetailedFacade();
                context.Items["IREQRequisitionItem_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
