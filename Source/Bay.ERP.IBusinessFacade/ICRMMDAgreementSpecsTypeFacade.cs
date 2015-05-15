// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMMDAgreementSpecsTypeFacade

    [ServiceContract(Name = "ICRMMDAgreementSpecsTypeFacade")]
    public partial interface ICRMMDAgreementSpecsTypeFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<CRMMDAgreementSpecsTypeEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        CRMMDAgreementSpecsTypeEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
