// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBDProjectParking
    {

        public FCCBDProjectParking()
        {

        }

        public static Bay.ERP.BusinessFacade.IBDProjectParkingFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBDProjectParkingFacade facade = context.Items["IBDProjectParkingFacade"] as Bay.ERP.BusinessFacade.IBDProjectParkingFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BDProjectParkingFacade();
                context.Items["IBDProjectParkingFacade"] = facade;
            }
            return facade;
        }


    }
}
