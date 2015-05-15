// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMCommunicationDataAccess

    public partial interface ICRMCommunicationDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CRMCommunicationEntity cRMCommunicationEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CRMCommunicationEntity cRMCommunicationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CRMCommunicationEntity> cRMCommunicationEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CRMCommunicationEntity> cRMCommunicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CRMCommunicationEntity> cRMCommunicationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CRMCommunicationEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}