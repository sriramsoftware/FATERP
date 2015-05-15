// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 11:09:08




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMMeasurementBook
    {

        public FCCCMMeasurementBook()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMMeasurementBookFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMMeasurementBookFacade facade = context.Items["ICMMeasurementBookFacade"] as Bay.ERP.BusinessFacade.ICMMeasurementBookFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMMeasurementBookFacade();
                context.Items["ICMMeasurementBookFacade"] = facade;
            }
            return facade;
        }


    }
}
