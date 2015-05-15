// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCACCurrencyExchangeRates
    {

        public FCCACCurrencyExchangeRates()
        {

        }

        public static Bay.ERP.BusinessFacade.IACCurrencyExchangeRatesFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IACCurrencyExchangeRatesFacade facade = context.Items["IACCurrencyExchangeRatesFacade"] as Bay.ERP.BusinessFacade.IACCurrencyExchangeRatesFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.ACCurrencyExchangeRatesFacade();
                context.Items["IACCurrencyExchangeRatesFacade"] = facade;
            }
            return facade;
        }


    }
}
