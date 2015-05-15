// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNFavorite
    {

        public FCCCMNFavorite()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNFavoriteFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNFavoriteFacade facade = context.Items["ICMNFavoriteFacade"] as Bay.ERP.BusinessFacade.ICMNFavoriteFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNFavoriteFacade();
                context.Items["ICMNFavoriteFacade"] = facade;
            }
            return facade;
        }


    }
}
