// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCDMSReferenceLibrary
    {

        public FCCDMSReferenceLibrary()
        {

        }

        public static Bay.ERP.BusinessFacade.IDMSReferenceLibraryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IDMSReferenceLibraryFacade facade = context.Items["IDMSReferenceLibraryFacade"] as Bay.ERP.BusinessFacade.IDMSReferenceLibraryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.DMSReferenceLibraryFacade();
                context.Items["IDMSReferenceLibraryFacade"] = facade;
            }
            return facade;
        }


    }
}
