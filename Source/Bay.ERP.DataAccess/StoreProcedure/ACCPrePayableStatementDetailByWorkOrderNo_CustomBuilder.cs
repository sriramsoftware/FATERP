// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Jan-2013, 05:35:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDetailByWorkOrderNo_CustomBuilder : IEntityBuilder<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity>
    {
        IList<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity> IEntityBuilder<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity> ACCPrePayableStatementDetailByWorkOrderNo_CustomEntityList = new List<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDetailByWorkOrderNo_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDetailByWorkOrderNo_CustomEntityList.Count > 0) ? ACCPrePayableStatementDetailByWorkOrderNo_CustomEntityList : null;
        }

        ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity IEntityBuilder<ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERPAYMENTTERMID = 0;
            const Int32 FLD_PAYMENTPERCENTAGE = 1;
            const Int32 FLD_COMPLETIONPERCENTAGE = 2;
            const Int32 FLD_PAYMENTDATE = 3;
            const Int32 FLD_COMPLETIONNOTE = 4;
            const Int32 FLD_WOAMOUNT = 5;
            const Int32 FLD_WORKORDERSTATUSID = 6;
            const Int32 FLD_WORKORDERID = 7;
            const Int32 FLD_WORKORDERNO = 8;
            const Int32 FLD_STARTDATE = 9;
            const Int32 FLD_SUPPLIERID = 10;

            ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity = new ACCPrePayableStatementDetailByWorkOrderNo_CustomEntity();

            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WorkOrderPaymentTermID = reader.GetInt64(FLD_WORKORDERPAYMENTTERMID);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.PaymentPercentage = reader.GetDecimal(FLD_PAYMENTPERCENTAGE);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE);
            if (reader.IsDBNull(FLD_PAYMENTDATE)) { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.PaymentDate = null; } else { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE); }
            if (reader.IsDBNull(FLD_COMPLETIONNOTE)) { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.CompletionNote = String.Empty; } else { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.CompletionNote = reader.GetString(FLD_COMPLETIONNOTE); }
            if (reader.IsDBNull(FLD_WOAMOUNT)) { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WOAmount = null; } else { aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WOAmount = reader.GetDecimal(FLD_WOAMOUNT); }
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);

            return aCCPrePayableStatementDetailByWorkOrderNo_CustomEntity;
        }
    }
}
