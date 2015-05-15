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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBulkInsertXMLFacade

    [ServiceContract(Name = "IBulkInsertXMLFacade")]
    public partial interface IBulkInsertXMLFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<BulkInsertXMLEntity> GetIL(String xVar, Int32 tableInfo);

        [OperationContract]
        DataTable GetDT(String xVar, Int32 tableInfo);

        #endregion Get

    }
    #endregion
}
