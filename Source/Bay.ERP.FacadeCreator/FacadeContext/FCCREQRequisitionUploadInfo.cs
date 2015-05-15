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
    public class FCCREQRequisitionUploadInfo
    {

        public FCCREQRequisitionUploadInfo()
        {

        }

        public static Bay.ERP.BusinessFacade.IREQRequisitionUploadInfoFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IREQRequisitionUploadInfoFacade facade = context.Items["IREQRequisitionUploadInfoFacade"] as Bay.ERP.BusinessFacade.IREQRequisitionUploadInfoFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.REQRequisitionUploadInfoFacade();
                context.Items["IREQRequisitionUploadInfoFacade"] = facade;
            }
            return facade;
        }


    }
}
