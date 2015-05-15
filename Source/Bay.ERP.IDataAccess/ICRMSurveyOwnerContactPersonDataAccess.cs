// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Oct-2013, 12:51:37




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMSurveyOwnerContactPersonDataAccess

    public partial interface ICRMSurveyOwnerContactPersonDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CRMSurveyOwnerContactPersonEntity cRMSurveyOwnerContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CRMSurveyOwnerContactPersonEntity> cRMSurveyOwnerContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CRMSurveyOwnerContactPersonEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
