// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jul-2012, 03:04:56




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderPaymentTerm_RPTBuilder : IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>
    {
        IList<PRMWorkOrderPaymentTerm_RPTEntity> IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderPaymentTerm_RPTEntity> PRMWorkOrderPaymentTerm_RPTEntityList = new List<PRMWorkOrderPaymentTerm_RPTEntity>();

            while (reader.Read())
            {
                PRMWorkOrderPaymentTerm_RPTEntityList.Add(((IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderPaymentTerm_RPTEntityList.Count > 0) ? PRMWorkOrderPaymentTerm_RPTEntityList : null;
        }

        PRMWorkOrderPaymentTerm_RPTEntity IEntityBuilder<PRMWorkOrderPaymentTerm_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERPAYMENTTERMID = 0;
            const Int32 FLD_WORKORDERID = 1;
            const Int32 FLD_PAYMENTPERCENTAGE = 2;
            const Int32 FLD_COMPLETIONPERCENTAGE = 3;
            const Int32 FLD_PAYMENTDATE = 4;
            const Int32 FLD_COMPLETIONNOTE = 5;
            const Int32 FLD_PAYMENTTERM = 6;

            PRMWorkOrderPaymentTerm_RPTEntity pRMWorkOrderPaymentTerm_RPTEntity = new PRMWorkOrderPaymentTerm_RPTEntity();

            pRMWorkOrderPaymentTerm_RPTEntity.WorkOrderPaymentTermID = reader.GetInt64(FLD_WORKORDERPAYMENTTERMID);
            pRMWorkOrderPaymentTerm_RPTEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderPaymentTerm_RPTEntity.PaymentPercentage = reader.GetDecimal(FLD_PAYMENTPERCENTAGE);
            pRMWorkOrderPaymentTerm_RPTEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE);
            if (reader.IsDBNull(FLD_PAYMENTDATE)) { pRMWorkOrderPaymentTerm_RPTEntity.PaymentDate = null; } else { pRMWorkOrderPaymentTerm_RPTEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE); }
            if (reader.IsDBNull(FLD_COMPLETIONNOTE)) { pRMWorkOrderPaymentTerm_RPTEntity.CompletionNote = String.Empty; } else { pRMWorkOrderPaymentTerm_RPTEntity.CompletionNote = reader.GetString(FLD_COMPLETIONNOTE); }
            if (reader.IsDBNull(FLD_PAYMENTTERM)) { pRMWorkOrderPaymentTerm_RPTEntity.PaymentTerm = String.Empty; } else { pRMWorkOrderPaymentTerm_RPTEntity.PaymentTerm = reader.GetString(FLD_PAYMENTTERM); }

            return pRMWorkOrderPaymentTerm_RPTEntity;
        }
    }
}
