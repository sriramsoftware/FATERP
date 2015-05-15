// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2012, 05:39:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisition_RPT
    {

        public FCCREQRequisition_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisition_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisition_RPTFacade facade = context.Items["IREQRequisition_RPTFacade"] as Bay.ERP.BusinessFacade.IREQRequisition_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisition_RPTFacade();
                context.Items["IREQRequisition_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
