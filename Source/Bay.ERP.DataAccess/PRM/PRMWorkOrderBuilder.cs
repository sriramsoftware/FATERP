// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrderBuilder : IEntityBuilder<PRMWorkOrderEntity>
    {
        IList<PRMWorkOrderEntity> IEntityBuilder<PRMWorkOrderEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrderEntity> PRMWorkOrderEntityList = new List<PRMWorkOrderEntity>();

            while (reader.Read())
            {
                PRMWorkOrderEntityList.Add(((IEntityBuilder<PRMWorkOrderEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrderEntityList.Count > 0) ? PRMWorkOrderEntityList : null;
        }

        PRMWorkOrderEntity IEntityBuilder<PRMWorkOrderEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_WORKORDERNO = 2;
            const Int32 FLD_ATTENTIONID = 3;
            const Int32 FLD_OTHERATTENTION = 4;
            const Int32 FLD_CREATEDATE = 5;
            const Int32 FLD_SUBJECT = 6;
            const Int32 FLD_BODYTITLE = 7;
            const Int32 FLD_STARTDATE = 8;
            const Int32 FLD_COMPLETIONDATE = 9;
            const Int32 FLD_WARRANTY = 10;
            const Int32 FLD_DELAYCHARGE = 11;
            const Int32 FLD_AIT = 12;
            const Int32 FLD_CARRYINGCHARGE = 13;
            const Int32 FLD_DISCOUNT = 14;
            const Int32 FLD_VAT = 15;
            const Int32 FLD_TAX = 16;
            const Int32 FLD_GRANDTOTAL = 17;
            const Int32 FLD_ROWTEXT = 18;
            const Int32 FLD_REMARKS = 19;
            const Int32 FLD_FOOTNOTE = 20;
            const Int32 FLD_PREPAREDBYID = 21;
            const Int32 FLD_WORKORDERSTATUSID = 22;
            const Int32 FLD_ISFINALBILLED = 23;

            PRMWorkOrderEntity pRMWorkOrderEntity = new PRMWorkOrderEntity();

            pRMWorkOrderEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrderEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMWorkOrderEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            if (reader.IsDBNull(FLD_ATTENTIONID)) { pRMWorkOrderEntity.AttentionID = null; } else { pRMWorkOrderEntity.AttentionID = reader.GetInt64(FLD_ATTENTIONID); }
            if (reader.IsDBNull(FLD_OTHERATTENTION)) { pRMWorkOrderEntity.OtherAttention = String.Empty; } else { pRMWorkOrderEntity.OtherAttention = reader.GetString(FLD_OTHERATTENTION); }
            pRMWorkOrderEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            pRMWorkOrderEntity.Subject = reader.GetString(FLD_SUBJECT);
            pRMWorkOrderEntity.BodyTitle = reader.GetString(FLD_BODYTITLE);
            pRMWorkOrderEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            pRMWorkOrderEntity.CompletionDate = reader.GetDateTime(FLD_COMPLETIONDATE);
            if (reader.IsDBNull(FLD_WARRANTY)) { pRMWorkOrderEntity.Warranty = String.Empty; } else { pRMWorkOrderEntity.Warranty = reader.GetString(FLD_WARRANTY); }
            if (reader.IsDBNull(FLD_DELAYCHARGE)) { pRMWorkOrderEntity.DelayCharge = String.Empty; } else { pRMWorkOrderEntity.DelayCharge = reader.GetString(FLD_DELAYCHARGE); }
            if (reader.IsDBNull(FLD_AIT)) { pRMWorkOrderEntity.AIT = null; } else { pRMWorkOrderEntity.AIT = reader.GetDecimal(FLD_AIT); }
            if (reader.IsDBNull(FLD_CARRYINGCHARGE)) { pRMWorkOrderEntity.CarryingCharge = null; } else { pRMWorkOrderEntity.CarryingCharge = reader.GetDecimal(FLD_CARRYINGCHARGE); }
            if (reader.IsDBNull(FLD_DISCOUNT)) { pRMWorkOrderEntity.Discount = null; } else { pRMWorkOrderEntity.Discount = reader.GetDecimal(FLD_DISCOUNT); }
            if (reader.IsDBNull(FLD_VAT)) { pRMWorkOrderEntity.VAT = null; } else { pRMWorkOrderEntity.VAT = reader.GetDecimal(FLD_VAT); }
            if (reader.IsDBNull(FLD_TAX)) { pRMWorkOrderEntity.Tax = null; } else { pRMWorkOrderEntity.Tax = reader.GetDecimal(FLD_TAX); }
            if (reader.IsDBNull(FLD_GRANDTOTAL)) { pRMWorkOrderEntity.GrandTotal = null; } else { pRMWorkOrderEntity.GrandTotal = reader.GetDecimal(FLD_GRANDTOTAL); }
            if (reader.IsDBNull(FLD_ROWTEXT)) { pRMWorkOrderEntity.RowText = String.Empty; } else { pRMWorkOrderEntity.RowText = reader.GetString(FLD_ROWTEXT); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMWorkOrderEntity.Remarks = String.Empty; } else { pRMWorkOrderEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_FOOTNOTE)) { pRMWorkOrderEntity.FootNote = String.Empty; } else { pRMWorkOrderEntity.FootNote = reader.GetString(FLD_FOOTNOTE); }
            pRMWorkOrderEntity.PreparedByID = reader.GetInt64(FLD_PREPAREDBYID);
            pRMWorkOrderEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            pRMWorkOrderEntity.IsFinalBilled = reader.GetBoolean(FLD_ISFINALBILLED);

            return pRMWorkOrderEntity;
        }
    }
}
