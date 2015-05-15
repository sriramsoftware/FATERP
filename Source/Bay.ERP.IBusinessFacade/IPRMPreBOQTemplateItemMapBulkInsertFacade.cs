// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2012, 03:42:46




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMPreBOQTemplateItemMapBulkInsertFacade

    [ServiceContract(Name = "IPRMPreBOQTemplateItemMapBulkInsertFacade")]
    public partial interface IPRMPreBOQTemplateItemMapBulkInsertFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMPreBOQTemplateItemMapBulkInsertEntity> GetIL(String xVar);

        [OperationContract]
        DataTable GetDT(String xVar);

        #endregion Get

    }
    #endregion
}
