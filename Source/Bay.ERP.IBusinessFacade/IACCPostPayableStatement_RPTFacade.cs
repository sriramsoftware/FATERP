// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2012, 11:48:21




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACCPostPayableStatement_RPTFacade

    [ServiceContract(Name = "IACCPostPayableStatement_RPTFacade")]
    public partial interface IACCPostPayableStatement_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACCPostPayableStatement_RPTEntity> GetIL(Int64 postPayableStatementID);

        [OperationContract]
        DataTable GetDT(Int64 postPayableStatementID);

        #endregion Get

    }
    #endregion
}
