// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jan-2012, 02:47:05




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionItem
    {

        public FCCREQRequisitionItem()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionItemFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionItemFacade facade = context.Items["IREQRequisitionItemFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionItemFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionItemFacade();
                context.Items["IREQRequisitionItemFacade"] = facade;
            }
            return facade;
        }


    }
}
