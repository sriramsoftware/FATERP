// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMBillMaterialReceiveMeasurementBookMapDataAccess

    public partial interface ICMBillMaterialReceiveMeasurementBookMapDataAccess
    {
        #region Save Update Delete List

        Int64 Add(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Update(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        Int64 Delete(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        IList<Int64> Add(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Update(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        IList<Int64> Delete(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        IList<CMBillMaterialReceiveMeasurementBookMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        #endregion Get

    }
    #endregion
}
