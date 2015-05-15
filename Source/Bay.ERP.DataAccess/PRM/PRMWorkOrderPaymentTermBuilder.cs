// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderPaymentTermBuilder : IEntityBuilder<PRMWorkOrderPaymentTermEntity>
    {
        IList<PRMWorkOrderPaymentTermEntity> IEntityBuilder<PRMWorkOrderPaymentTermEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderPaymentTermEntity> PRMWorkOrderPaymentTermEntityList = new List<PRMWorkOrderPaymentTermEntity>();

            while (reader.Read())
            {
                PRMWorkOrderPaymentTermEntityList.Add(((IEntityBuilder<PRMWorkOrderPaymentTermEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderPaymentTermEntityList.Count > 0) ? PRMWorkOrderPaymentTermEntityList : null;
        }

        PRMWorkOrderPaymentTermEntity IEntityBuilder<PRMWorkOrderPaymentTermEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERPAYMENTTERMID = 0;
            const Int32 FLD_WORKORDERID = 1;
            const Int32 FLD_PAYMENTPERCENTAGE = 2;
            const Int32 FLD_COMPLETIONPERCENTAGE = 3;
            const Int32 FLD_COMPLETIONNOTE = 4;
            const Int32 FLD_PAYMENTDATE = 5;

            PRMWorkOrderPaymentTermEntity pRMWorkOrderPaymentTermEntity = new PRMWorkOrderPaymentTermEntity();

            pRMWorkOrderPaymentTermEntity.WorkOrderPaymentTermID = reader.GetInt64(FLD_WORKORDERPAYMENTTERMID);
            pRMWorkOrderPaymentTermEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderPaymentTermEntity.PaymentPercentage = reader.GetDecimal(FLD_PAYMENTPERCENTAGE);
            pRMWorkOrderPaymentTermEntity.CompletionPercentage = reader.GetDecimal(FLD_COMPLETIONPERCENTAGE);
            if (reader.IsDBNull(FLD_COMPLETIONNOTE)) { pRMWorkOrderPaymentTermEntity.CompletionNote = String.Empty; } else { pRMWorkOrderPaymentTermEntity.CompletionNote = reader.GetString(FLD_COMPLETIONNOTE); }
            if (reader.IsDBNull(FLD_PAYMENTDATE)) { pRMWorkOrderPaymentTermEntity.PaymentDate = null; } else { pRMWorkOrderPaymentTermEntity.PaymentDate = reader.GetDateTime(FLD_PAYMENTDATE); }

            return pRMWorkOrderPaymentTermEntity;
        }
    }
}
