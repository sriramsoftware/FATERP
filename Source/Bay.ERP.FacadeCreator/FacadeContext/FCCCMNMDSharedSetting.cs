// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNMDSharedSetting
    {

        public FCCCMNMDSharedSetting()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNMDSharedSettingFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNMDSharedSettingFacade facade = context.Items["ICMNMDSharedSettingFacade"] as Bay.ERP.BusinessFacade.ICMNMDSharedSettingFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNMDSharedSettingFacade();
                context.Items["ICMNMDSharedSettingFacade"] = facade;
            }
            return facade;
        }


    }
}