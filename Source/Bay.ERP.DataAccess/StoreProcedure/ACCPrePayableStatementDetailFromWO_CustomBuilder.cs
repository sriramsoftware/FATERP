// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Jan-2013, 10:00:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDetailFromWO_CustomBuilder : IEntityBuilder<ACCPrePayableStatementDetailFromWO_CustomEntity>
    {
        IList<ACCPrePayableStatementDetailFromWO_CustomEntity> IEntityBuilder<ACCPrePayableStatementDetailFromWO_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDetailFromWO_CustomEntity> ACCPrePayableStatementDetailFromWO_CustomEntityList = new List<ACCPrePayableStatementDetailFromWO_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDetailFromWO_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDetailFromWO_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDetailFromWO_CustomEntityList.Count > 0) ? ACCPrePayableStatementDetailFromWO_CustomEntityList : null;
        }

        ACCPrePayableStatementDetailFromWO_CustomEntity IEntityBuilder<ACCPrePayableStatementDetailFromWO_CustomEntity>.BuildEntity(IDataReader reader)
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

            ACCPrePayableStatementDetailFromWO_CustomEntity aCCPrePayableStatementDetailFromWO_CustomEntity = new ACCPrePayableStatementDetailFromWO_CustomEntity();

            aCCPrePayableStatementDetailFromWO_CustomEntity.WorkOrderPaymentTermID = reader.GetInt64(FLD_WORKORDERPAYMENTTERMID);
            aCCPrePayableStatementDetailFromWO_CustomEntity.PaymentPercentage = reader.GetDecimal(FLD_PAYMENTPERCENTAGE);
            aCCPrePayableStatementDetailFromWO_CustomEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE);
            if (reader.IsDBNull(FLD_PAYMENTDATE)) { aCCPrePayableStatementDetailFromWO_CustomEntity.PaymentDate = null; } else { aCCPrePayableStatementDetailFromWO_CustomEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE); }
            if (reader.IsDBNull(FLD_COMPLETIONNOTE)) { aCCPrePayableStatementDetailFromWO_CustomEntity.CompletionNote = String.Empty; } else { aCCPrePayableStatementDetailFromWO_CustomEntity.CompletionNote = reader.GetString(FLD_COMPLETIONNOTE); }
            if (reader.IsDBNull(FLD_WOAMOUNT)) { aCCPrePayableStatementDetailFromWO_CustomEntity.WOAmount = null; } else { aCCPrePayableStatementDetailFromWO_CustomEntity.WOAmount = reader.GetDecimal(FLD_WOAMOUNT); }
            aCCPrePayableStatementDetailFromWO_CustomEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            aCCPrePayableStatementDetailFromWO_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            aCCPrePayableStatementDetailFromWO_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            aCCPrePayableStatementDetailFromWO_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            aCCPrePayableStatementDetailFromWO_CustomEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);

            return aCCPrePayableStatementDetailFromWO_CustomEntity;
        }
    }
}
