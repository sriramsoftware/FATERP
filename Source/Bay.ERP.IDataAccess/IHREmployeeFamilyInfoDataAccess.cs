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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeFamilyInfoDataAccess

    public partial interface IHREmployeeFamilyInfoDataAccess
    {
        #region Save Update Delete List

        Int64 Add(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<HREmployeeFamilyInfoEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
