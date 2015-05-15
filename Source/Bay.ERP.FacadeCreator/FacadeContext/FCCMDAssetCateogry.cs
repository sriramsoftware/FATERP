// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDAssetCateogry
    {

        public FCCMDAssetCateogry()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAssetCateogryFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAssetCateogryFacade facade = context.Items["IMDAssetCateogryFacade"] as Bay.ERP.BusinessFacade.IMDAssetCateogryFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAssetCateogryFacade();
                context.Items["IMDAssetCateogryFacade"] = facade;
            }
            return facade;
        }


    }
}
