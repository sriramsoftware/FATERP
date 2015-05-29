// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IMDOperatorAddressTypeFacade

    [ServiceContract(Name = "IMDOperatorAddressTypeFacade")]
    public partial interface IMDOperatorAddressTypeFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<MDOperatorAddressTypeEntity> mDOperatorAddressTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<MDOperatorAddressTypeEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        MDOperatorAddressTypeEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
