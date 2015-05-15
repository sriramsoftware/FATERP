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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMBillMaterialReceiveMeasurementBookMapFacade

    [ServiceContract(Name = "ICMBillMaterialReceiveMeasurementBookMapFacade")]
    public partial interface ICMBillMaterialReceiveMeasurementBookMapFacade : IDisposable
    {        
        #region Save Update Delete List

        [OperationContract]
        Int64 Add(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Update(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        Int64 Delete(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete List

        #region Save Update Delete Lists

        [OperationContract]
        IList<Int64> Add(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Update(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        [OperationContract]
        IList<Int64> Delete(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran);

        #endregion Save Update Delete Lists

        #region Get

        [OperationContract]
        IList<CMBillMaterialReceiveMeasurementBookMapEntity> GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        DataTable GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option);

        [OperationContract]
        CMBillMaterialReceiveMeasurementBookMapEntity GetByID(Int64 iD);

        #endregion Get

    }
    #endregion
}
