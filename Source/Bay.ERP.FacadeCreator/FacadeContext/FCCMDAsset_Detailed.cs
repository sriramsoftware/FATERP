// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 11:23:45




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDAsset_Detailed
    {

        public FCCMDAsset_Detailed()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAsset_DetailedFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAsset_DetailedFacade facade = context.Items["IMDAsset_DetailedFacade"] as Bay.ERP.BusinessFacade.IMDAsset_DetailedFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAsset_DetailedFacade();
                context.Items["IMDAsset_DetailedFacade"] = facade;
            }
            return facade;
        }


    }
}
