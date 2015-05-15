// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVStoreIssueNoteItemMap
    {

        public FCCINVStoreIssueNoteItemMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMapFacade facade = context.Items["IINVStoreIssueNoteItemMapFacade"] as Bay.ERP.BusinessFacade.IINVStoreIssueNoteItemMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVStoreIssueNoteItemMapFacade();
                context.Items["IINVStoreIssueNoteItemMapFacade"] = facade;
            }
            return facade;
        }


    }
}
