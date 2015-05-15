// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACDebitCreditRuleElementFacade

    [ServiceContract(Name = "IACDebitCreditRuleElementFacade")]
    public partial interface IACDebitCreditRuleElementFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(ACDebitCreditRuleElementEntity aCDebitCreditRuleElementEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<ACDebitCreditRuleElementEntity> aCDebitCreditRuleElementEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<ACDebitCreditRuleElementEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        ACDebitCreditRuleElementEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
