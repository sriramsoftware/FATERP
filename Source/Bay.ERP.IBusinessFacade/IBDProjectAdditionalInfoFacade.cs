// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDProjectAdditionalInfoFacade

    [ServiceContract(Name = "IBDProjectAdditionalInfoFacade")]
    public partial interface IBDProjectAdditionalInfoFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(BDProjectAdditionalInfoEntity bDProjectAdditionalInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<BDProjectAdditionalInfoEntity> bDProjectAdditionalInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<BDProjectAdditionalInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        BDProjectAdditionalInfoEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
