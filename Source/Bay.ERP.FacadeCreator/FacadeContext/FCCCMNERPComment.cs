// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

using Bay.ERP.BusinessFacade;

namespace Bay.ERP.FacadeCreator.FacadeContext
{
    public class FCCCMNERPComment
    {

        public FCCCMNERPComment()
        {

        }

        public static Bay.ERP.BusinessFacade.ICMNERPCommentFacade GetFacadeCreate()
        {
            HttpContext context = HttpContext.Current;

            Bay.ERP.BusinessFacade.ICMNERPCommentFacade facade = context.Items["ICMNERPCommentFacade"] as Bay.ERP.BusinessFacade.ICMNERPCommentFacade;

            if (facade == null)
            {
                facade = new Bay.ERP.BusinessFacade.CMNERPCommentFacade();
                context.Items["ICMNERPCommentFacade"] = facade;
            }
            return facade;
        }


    }
}
