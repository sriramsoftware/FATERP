// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2012, 11:26:30




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMBillUploadInfo
    {

        public FCCCMBillUploadInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMBillUploadInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMBillUploadInfoFacade facade = context.Items["ICMBillUploadInfoFacade"] as Bay.ERP.BusinessFacade.ICMBillUploadInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMBillUploadInfoFacade();
                context.Items["ICMBillUploadInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
