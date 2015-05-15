// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 01:47:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDetail_CustomBuilder : IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>
    {
        IList<ACCPrePayableStatementDetail_CustomEntity> IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDetail_CustomEntity> ACCPrePayableStatementDetail_CustomEntityList = new List<ACCPrePayableStatementDetail_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDetail_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDetail_CustomEntityList.Count > 0) ? ACCPrePayableStatementDetail_CustomEntityList : null;
        }

        ACCPrePayableStatementDetail_CustomEntity IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLID = 0;
            const Int32 FLD_BILLNO = 1;
            const Int32 FLD_BILLAMOUNT = 2;
            const Int32 FLD_BILLLDATE = 3;
            const Int32 FLD_PROJECTID = 4;
            const Int32 FLD_VENDORCATEGORY = 5;
            const Int32 FLD_VENDOR = 6;
            const Int32 FLD_WOAMOUNT = 7;
            const Int32 FLD_WORKORDERID = 8;
            const Int32 FLD_REQUISITIONID = 9;
            const Int32 FLD_REQUISITIONNO = 10;
            const Int32 FLD_REQUISITIONDATE = 11;
            const Int32 FLD_WORKORDERNO = 12;
            const Int32 FLD_PROJECTNAME = 13;
            const Int32 FLD_PROJECTCODE = 14;
            const Int32 FLD_BILLAPPROVALSTATUSID = 15;
            const Int32 FLD_STARTDATE = 16;

            ACCPrePayableStatementDetail_CustomEntity aCCPrePayableStatementDetail_CustomEntity = new ACCPrePayableStatementDetail_CustomEntity();

            if (reader.IsDBNull(FLD_BILLID)) { aCCPrePayableStatementDetail_CustomEntity.BillID = null; } else { aCCPrePayableStatementDetail_CustomEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPrePayableStatementDetail_CustomEntity.BillNo = String.Empty; } else { aCCPrePayableStatementDetail_CustomEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLAMOUNT)) { aCCPrePayableStatementDetail_CustomEntity.BillAmount = null; } else { aCCPrePayableStatementDetail_CustomEntity.BillAmount = reader.GetDecimal(FLD_BILLAMOUNT); }
            if (reader.IsDBNull(FLD_BILLLDATE)) { aCCPrePayableStatementDetail_CustomEntity.billlDate = null; } else { aCCPrePayableStatementDetail_CustomEntity.billlDate = reader.GetDateTime(FLD_BILLLDATE); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCCPrePayableStatementDetail_CustomEntity.ProjectID = null; } else { aCCPrePayableStatementDetail_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_VENDORCATEGORY)) { aCCPrePayableStatementDetail_CustomEntity.VendorCategory = null; } else { aCCPrePayableStatementDetail_CustomEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY); }
            if (reader.IsDBNull(FLD_VENDOR)) { aCCPrePayableStatementDetail_CustomEntity.Vendor = null; } else { aCCPrePayableStatementDetail_CustomEntity.Vendor = reader.GetInt64(FLD_VENDOR); }
            if (reader.IsDBNull(FLD_WOAMOUNT)) { aCCPrePayableStatementDetail_CustomEntity.WOAmount = null; } else { aCCPrePayableStatementDetail_CustomEntity.WOAmount = reader.GetDecimal(FLD_WOAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPrePayableStatementDetail_CustomEntity.WorkOrderID = null; } else { aCCPrePayableStatementDetail_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPrePayableStatementDetail_CustomEntity.RequisitionID = null; } else { aCCPrePayableStatementDetail_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPrePayableStatementDetail_CustomEntity.RequisitionNo = String.Empty; } else { aCCPrePayableStatementDetail_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPrePayableStatementDetail_CustomEntity.RequisitionDate = null; } else { aCCPrePayableStatementDetail_CustomEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPrePayableStatementDetail_CustomEntity.WorkOrderNo = String.Empty; } else { aCCPrePayableStatementDetail_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCCPrePayableStatementDetail_CustomEntity.ProjectName = String.Empty; } else { aCCPrePayableStatementDetail_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPrePayableStatementDetail_CustomEntity.ProjectCode = String.Empty; } else { aCCPrePayableStatementDetail_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_BILLAPPROVALSTATUSID)) { aCCPrePayableStatementDetail_CustomEntity.BillApprovalStatusID = null; } else { aCCPrePayableStatementDetail_CustomEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID); }
            if (reader.IsDBNull(FLD_STARTDATE)) { aCCPrePayableStatementDetail_CustomEntity.StartDate = null; } else { aCCPrePayableStatementDetail_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }

            return aCCPrePayableStatementDetail_CustomEntity;
        }
    }
}
