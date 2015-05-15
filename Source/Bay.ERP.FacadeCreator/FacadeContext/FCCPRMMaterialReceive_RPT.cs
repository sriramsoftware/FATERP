// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jul-2012, 11:22:51




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCPRMMaterialReceive_RPT
    {

        public FCCPRMMaterialReceive_RPT()
        {

        }

        public static Bay.ERP.BusinessFacade.IPRMMaterialReceive_RPTFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IPRMMaterialReceive_RPTFacade facade = context.Items["IPRMMaterialReceive_RPTFacade"] as Bay.ERP.BusinessFacade.IPRMMaterialReceive_RPTFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.PRMMaterialReceive_RPTFacade();
                context.Items["IPRMMaterialReceive_RPTFacade"] = facade;
            }
            return facade;
        }


    }
}
