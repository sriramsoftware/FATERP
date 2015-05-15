// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCINVTRFStoreIssueNoteMap
    {

        public FCCINVTRFStoreIssueNoteMap()
        {

        }

        public static Bay.ERP.BusinessFacade.IINVTRFStoreIssueNoteMapFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IINVTRFStoreIssueNoteMapFacade facade = context.Items["IINVTRFStoreIssueNoteMapFacade"] as Bay.ERP.BusinessFacade.IINVTRFStoreIssueNoteMapFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.INVTRFStoreIssueNoteMapFacade();
                context.Items["IINVTRFStoreIssueNoteMapFacade"] = facade;
            }
            return facade;
        }


    }
}
