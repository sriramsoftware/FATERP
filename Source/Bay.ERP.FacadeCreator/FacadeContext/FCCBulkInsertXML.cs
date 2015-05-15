// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2012, 02:37:15




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCBulkInsertXML
    {

        public FCCBulkInsertXML()
        {

        }

        public static Bay.ERP.BusinessFacade.IBulkInsertXMLFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.IBulkInsertXMLFacade facade = context.Items["IBulkInsertXMLFacade"] as Bay.ERP.BusinessFacade.IBulkInsertXMLFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.BulkInsertXMLFacade();
                context.Items["IBulkInsertXMLFacade"] = facade;
            }
            return facade;
        }


    }
}
