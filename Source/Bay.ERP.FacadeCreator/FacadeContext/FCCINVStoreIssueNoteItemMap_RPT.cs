// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Dec-2013, 10:00:46




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVStoreIssueNoteItemMap_RPT
    {

        public FCCINVStoreIssueNoteItemMap_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMap_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMap_RPTFacade facade = context.Items["IINVStoreIssueNoteItemMap_RPTFacade"] as Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMap_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVStoreIssueNoteItemMap_RPTFacade();
                context.Items["IINVStoreIssueNoteItemMap_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
