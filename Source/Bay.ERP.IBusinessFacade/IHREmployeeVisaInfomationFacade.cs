// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeVisaInfomationFacade

    [ServiceContract(Name = "IHREmployeeVisaInfomationFacade")]
    public partial interface IHREmployeeVisaInfomationFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<HREmployeeVisaInfomationEntity> hREmployeeVisaInfomationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<HREmployeeVisaInfomationEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        HREmployeeVisaInfomationEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}