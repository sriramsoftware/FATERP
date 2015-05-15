// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 06:33:35




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeLeaveApplicationFacade

    [ServiceContract(Name = "IHREmployeeLeaveApplicationFacade")]
    public partial interface IHREmployeeLeaveApplicationFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(HREmployeeLeaveApplicationEntity hREmployeeLeaveApplicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<HREmployeeLeaveApplicationEntity> hREmployeeLeaveApplicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<HREmployeeLeaveApplicationEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        HREmployeeLeaveApplicationEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
