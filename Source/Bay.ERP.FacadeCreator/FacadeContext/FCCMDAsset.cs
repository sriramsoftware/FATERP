// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Nov-2013, 09:51:38




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCMDAsset
    {

        public FCCMDAsset()
        {

        }

        public static Bay.ERP.BusinessFacade.IMDAssetFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IMDAssetFacade facade = context.Items["IMDAssetFacade"] as Bay.ERP.BusinessFacade.IMDAssetFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.MDAssetFacade();
                context.Items["IMDAssetFacade"] = facade;
            }
            return facade;
        }


    }
}
