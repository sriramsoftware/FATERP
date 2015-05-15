// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCHREmployeeBankAccountInformation
    {

        public FCCHREmployeeBankAccountInformation()
        {

        }

        public static Bay.ERP.BusinessFacade.IHREmployeeBankAccountInformationFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IHREmployeeBankAccountInformationFacade facade = context.Items["IHREmployeeBankAccountInformationFacade"] as Bay.ERP.BusinessFacade.IHREmployeeBankAccountInformationFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.HREmployeeBankAccountInformationFacade();
                context.Items["IHREmployeeBankAccountInformationFacade"] = facade;
            }
            return facade;
        }


    }
}
