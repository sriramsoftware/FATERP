// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMBOQTemplateDataAccess

    public partial interface IPRMBOQTemplateDataAccess
    {
        #region Save Update Delete List

        Int64 Add(PRMBOQTemplateEntity pRMBOQTemplateEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(PRMBOQTemplateEntity pRMBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(PRMBOQTemplateEntity pRMBOQTemplateEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<PRMBOQTemplateEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
