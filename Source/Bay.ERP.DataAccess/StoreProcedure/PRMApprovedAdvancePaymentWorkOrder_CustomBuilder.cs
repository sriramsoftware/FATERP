// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 11:05:44




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMApprovedAdvancePaymentWorkOrder_CustomBuilder : IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>
    {
        IList<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> PRMApprovedAdvancePaymentWorkOrder_CustomEntityList = new List<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>();

            while (reader.Read())
            {
                PRMApprovedAdvancePaymentWorkOrder_CustomEntityList.Add(((IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>)this).BuildEntity(reader));
            }

            return (PRMApprovedAdvancePaymentWorkOrder_CustomEntityList.Count > 0) ? PRMApprovedAdvancePaymentWorkOrder_CustomEntityList : null;
        }

        PRMApprovedAdvancePaymentWorkOrder_CustomEntity IEntityBuilder<PRMApprovedAdvancePaymentWorkOrder_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERPAYMENTTERMID = 0;
            const Int32 FLD_PAYMENTPERCENTAGE = 1;
            const Int32 FLD_COMPLETIONPERCENTAGE = 2;
            const Int32 FLD_PAYMENTDATE = 3;
            const Int32 FLD_COMPLETIONNOTE = 4;
            const Int32 FLD_WORKORDERSTATUSID = 5;
            const Int32 FLD_WORKORDERID = 6;
            const Int32 FLD_WORKORDERNO = 7;
            const Int32 FLD_STARTDATE = 8;

            PRMApprovedAdvancePaymentWorkOrder_CustomEntity pRMApprovedAdvancePaymentWorkOrder_CustomEntity = new PRMApprovedAdvancePaymentWorkOrder_CustomEntity();

            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.WorkOrderPaymentTermID = reader.GetInt64(FLD_WORKORDERPAYMENTTERMID);
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.PaymentPercentage = reader.GetDecimal(FLD_PAYMENTPERCENTAGE);
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE);
            if (reader.IsDBNull(FLD_PAYMENTDATE)) { pRMApprovedAdvancePaymentWorkOrder_CustomEntity.PaymentDate = null; } else { pRMApprovedAdvancePaymentWorkOrder_CustomEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE); }
            if (reader.IsDBNull(FLD_COMPLETIONNOTE)) { pRMApprovedAdvancePaymentWorkOrder_CustomEntity.CompletionNote = String.Empty; } else { pRMApprovedAdvancePaymentWorkOrder_CustomEntity.CompletionNote = reader.GetString(FLD_COMPLETIONNOTE); }
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            pRMApprovedAdvancePaymentWorkOrder_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);

            return pRMApprovedAdvancePaymentWorkOrder_CustomEntity;
        }
    }
}
