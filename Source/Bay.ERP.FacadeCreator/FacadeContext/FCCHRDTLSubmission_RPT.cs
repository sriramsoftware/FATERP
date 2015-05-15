// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2013, 12:20:17




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHRDTLSubmission_RPT
    {

        public FCCHRDTLSubmission_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IHRDTLSubmission_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHRDTLSubmission_RPTFacade facade = context.Items["IHRDTLSubmission_RPTFacade"] as Bay.ERP.BusinessFacade.IHRDTLSubmission_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HRDTLSubmission_RPTFacade();
                context.Items["IHRDTLSubmission_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
