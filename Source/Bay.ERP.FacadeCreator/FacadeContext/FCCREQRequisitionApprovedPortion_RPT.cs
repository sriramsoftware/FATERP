// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 11:35:58




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCREQRequisitionApprovedPortion_RPT
    {

        public FCCREQRequisitionApprovedPortion_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionApprovedPortion_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionApprovedPortion_RPTFacade facade = context.Items["IREQRequisitionApprovedPortion_RPTFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionApprovedPortion_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionApprovedPortion_RPTFacade();
                context.Items["IREQRequisitionApprovedPortion_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
