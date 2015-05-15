// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IDMSFileMovementRegisterFacade

    [ServiceContract(Name = "IDMSFileMovementRegisterFacade")]
    public partial interface IDMSFileMovementRegisterFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<DMSFileMovementRegisterEntity> dMSFileMovementRegisterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<DMSFileMovementRegisterEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DMSFileMovementRegisterEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
