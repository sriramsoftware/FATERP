// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Nov-2012, 10:07:19




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMWorkOrder_DetailedBuilder : IEntityBuilder<PRMWorkOrder_DetailedEntity>
    {
        IList<PRMWorkOrder_DetailedEntity> IEntityBuilder<PRMWorkOrder_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMWorkOrder_DetailedEntity> PRMWorkOrder_DetailedEntityList = new List<PRMWorkOrder_DetailedEntity>();

            while (reader.Read())
            {
                PRMWorkOrder_DetailedEntityList.Add(((IEntityBuilder<PRMWorkOrder_DetailedEntity>)this).BuildEntity(reader));
            }

            return (PRMWorkOrder_DetailedEntityList.Count > 0) ? PRMWorkOrder_DetailedEntityList : null;
        }

        PRMWorkOrder_DetailedEntity IEntityBuilder<PRMWorkOrder_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKORDERID = 0;
            const Int32 FLD_SUPPLIERID = 1;
            const Int32 FLD_WORKORDERNO = 2;
            const Int32 FLD_ATTENTIONID = 3;
            const Int32 FLD_CREATEDATE = 4;
            const Int32 FLD_SUBJECT = 5;
            const Int32 FLD_BODYTITLE = 6;
            const Int32 FLD_STARTDATE = 7;
            const Int32 FLD_COMPLETIONDATE = 8;
            const Int32 FLD_WARRANTY = 9;
            const Int32 FLD_DELAYCHARGE = 10;
            const Int32 FLD_REMARKS = 11;
            const Int32 FLD_FOOTNOTE = 12;
            const Int32 FLD_PREPAREDBYID = 13;
            const Int32 FLD_WORKORDERSTATUSID = 14;
            const Int32 FLD_PRMSUPPLIERSUPPLIERNAME = 15;
            const Int32 FLD_ATTENTIONFULLNAME = 16;
            const Int32 FLD_PREPAREDBYFULLNAME = 17;
            const Int32 FLD_MDWORKORDERSTATUSNAME = 18;
            const Int32 FLD_ROWNUMBER = 19;

            PRMWorkOrder_DetailedEntity pRMWorkOrder_DetailedEntity = new PRMWorkOrder_DetailedEntity();

            pRMWorkOrder_DetailedEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID);
            pRMWorkOrder_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID);
            pRMWorkOrder_DetailedEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO);
            if (reader.IsDBNull(FLD_ATTENTIONID)) { pRMWorkOrder_DetailedEntity.AttentionID = null; } else { pRMWorkOrder_DetailedEntity.AttentionID = reader.GetInt64(FLD_ATTENTIONID); }
            pRMWorkOrder_DetailedEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            pRMWorkOrder_DetailedEntity.Subject = reader.GetString(FLD_SUBJECT);
            pRMWorkOrder_DetailedEntity.BodyTitle = reader.GetString(FLD_BODYTITLE);
            pRMWorkOrder_DetailedEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            pRMWorkOrder_DetailedEntity.CompletionDate = reader.GetDateTime(FLD_COMPLETIONDATE);
            if (reader.IsDBNull(FLD_WARRANTY)) { pRMWorkOrder_DetailedEntity.Warranty = String.Empty; } else { pRMWorkOrder_DetailedEntity.Warranty = reader.GetString(FLD_WARRANTY); }
            if (reader.IsDBNull(FLD_DELAYCHARGE)) { pRMWorkOrder_DetailedEntity.DelayCharge = String.Empty; } else { pRMWorkOrder_DetailedEntity.DelayCharge = reader.GetString(FLD_DELAYCHARGE); }
            if (reader.IsDBNull(FLD_REMARKS)) { pRMWorkOrder_DetailedEntity.Remarks = String.Empty; } else { pRMWorkOrder_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_FOOTNOTE)) { pRMWorkOrder_DetailedEntity.FootNote = String.Empty; } else { pRMWorkOrder_DetailedEntity.FootNote = reader.GetString(FLD_FOOTNOTE); }
            pRMWorkOrder_DetailedEntity.PreparedByID = reader.GetInt64(FLD_PREPAREDBYID);
            pRMWorkOrder_DetailedEntity.WorkOrderStatusID = reader.GetInt64(FLD_WORKORDERSTATUSID);
            if (reader.IsDBNull(FLD_PRMSUPPLIERSUPPLIERNAME)) { pRMWorkOrder_DetailedEntity.PRMSupplierSupplierName = String.Empty; } else { pRMWorkOrder_DetailedEntity.PRMSupplierSupplierName = reader.GetString(FLD_PRMSUPPLIERSUPPLIERNAME); }
            if (reader.IsDBNull(FLD_ATTENTIONFULLNAME)) { pRMWorkOrder_DetailedEntity.AttentionFullName = String.Empty; } else { pRMWorkOrder_DetailedEntity.AttentionFullName = reader.GetString(FLD_ATTENTIONFULLNAME); }
            if (reader.IsDBNull(FLD_PREPAREDBYFULLNAME)) { pRMWorkOrder_DetailedEntity.PreparedByFullName = String.Empty; } else { pRMWorkOrder_DetailedEntity.PreparedByFullName = reader.GetString(FLD_PREPAREDBYFULLNAME); }
            if (reader.IsDBNull(FLD_MDWORKORDERSTATUSNAME)) { pRMWorkOrder_DetailedEntity.MDWorkOrderStatusName = String.Empty; } else { pRMWorkOrder_DetailedEntity.MDWorkOrderStatusName = reader.GetString(FLD_MDWORKORDERSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { pRMWorkOrder_DetailedEntity.RowNumber = null; } else { pRMWorkOrder_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return pRMWorkOrder_DetailedEntity;
        }
    }
}
