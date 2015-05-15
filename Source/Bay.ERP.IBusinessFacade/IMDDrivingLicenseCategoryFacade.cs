// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IMDDrivingLicenseCategoryFacade

    [ServiceContract(Name = "IMDDrivingLicenseCategoryFacade")]
    public partial interface IMDDrivingLicenseCategoryFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(MDDrivingLicenseCategoryEntity mDDrivingLicenseCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<MDDrivingLicenseCategoryEntity> mDDrivingLicenseCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<MDDrivingLicenseCategoryEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        MDDrivingLicenseCategoryEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
