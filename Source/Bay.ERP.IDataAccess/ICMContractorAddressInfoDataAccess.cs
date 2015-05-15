// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMContractorAddressInfoDataAccess

    public partial interface ICMContractorAddressInfoDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMContractorAddressInfoEntity cMContractorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMContractorAddressInfoEntity> cMContractorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMContractorAddressInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
