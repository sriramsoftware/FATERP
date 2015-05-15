// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCAPType
    {

        public FCCAPType()
        {

        }

        public static Bay.ERP.BusinessFacade.IAPTypeFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IAPTypeFacade facade = context.Items["IAPTypeFacade"] as Bay.ERP.BusinessFacade.IAPTypeFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.APTypeFacade();
                context.Items["IAPTypeFacade"] = facade;
            }
            return facade;
        }


    }
}