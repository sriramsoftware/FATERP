// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 02:36:29




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementDetailByBill_CustomBuilder : IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>
    {
        IList<ACCPrePayableStatementDetailByBill_CustomEntity> IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementDetailByBill_CustomEntity> ACCPrePayableStatementDetailByBill_CustomEntityList = new List<ACCPrePayableStatementDetailByBill_CustomEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementDetailByBill_CustomEntityList.Add(((IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementDetailByBill_CustomEntityList.Count > 0) ? ACCPrePayableStatementDetailByBill_CustomEntityList : null;
        }

        ACCPrePayableStatementDetailByBill_CustomEntity IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>.BuildEntity(IDataReader reader)
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

            ACCPrePayableStatementDetailByBill_CustomEntity aCCPrePayableStatementDetailByBill_CustomEntity = new ACCPrePayableStatementDetailByBill_CustomEntity();

            if (reader.IsDBNull(FLD_BILLID)) { aCCPrePayableStatementDetailByBill_CustomEntity.BillID = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.BillID = reader.GetInt64(FLD_BILLID); }
            if (reader.IsDBNull(FLD_BILLNO)) { aCCPrePayableStatementDetailByBill_CustomEntity.BillNo = String.Empty; } else { aCCPrePayableStatementDetailByBill_CustomEntity.BillNo = reader.GetString(FLD_BILLNO); }
            if (reader.IsDBNull(FLD_BILLAMOUNT)) { aCCPrePayableStatementDetailByBill_CustomEntity.BillAmount = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.BillAmount = reader.GetDecimal(FLD_BILLAMOUNT); }
            if (reader.IsDBNull(FLD_BILLLDATE)) { aCCPrePayableStatementDetailByBill_CustomEntity.billlDate = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.billlDate = reader.GetDateTime(FLD_BILLLDATE); }
            if (reader.IsDBNull(FLD_PROJECTID)) { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectID = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_VENDORCATEGORY)) { aCCPrePayableStatementDetailByBill_CustomEntity.VendorCategory = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY); }
            if (reader.IsDBNull(FLD_VENDOR)) { aCCPrePayableStatementDetailByBill_CustomEntity.Vendor = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.Vendor = reader.GetInt64(FLD_VENDOR); }
            if (reader.IsDBNull(FLD_WOAMOUNT)) { aCCPrePayableStatementDetailByBill_CustomEntity.WOAmount = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.WOAmount = reader.GetDecimal(FLD_WOAMOUNT); }
            if (reader.IsDBNull(FLD_WORKORDERID)) { aCCPrePayableStatementDetailByBill_CustomEntity.WorkOrderID = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.WorkOrderID = reader.GetInt64(FLD_WORKORDERID); }
            if (reader.IsDBNull(FLD_REQUISITIONID)) { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionID = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionID = reader.GetInt64(FLD_REQUISITIONID); }
            if (reader.IsDBNull(FLD_REQUISITIONNO)) { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionNo = String.Empty; } else { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionNo = reader.GetString(FLD_REQUISITIONNO); }
            if (reader.IsDBNull(FLD_REQUISITIONDATE)) { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionDate = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.RequisitionDate = reader.GetDateTime(FLD_REQUISITIONDATE); }
            if (reader.IsDBNull(FLD_WORKORDERNO)) { aCCPrePayableStatementDetailByBill_CustomEntity.WorkOrderNo = String.Empty; } else { aCCPrePayableStatementDetailByBill_CustomEntity.WorkOrderNo = reader.GetString(FLD_WORKORDERNO); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectName = String.Empty; } else { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_PROJECTCODE)) { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectCode = String.Empty; } else { aCCPrePayableStatementDetailByBill_CustomEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE); }
            if (reader.IsDBNull(FLD_BILLAPPROVALSTATUSID)) { aCCPrePayableStatementDetailByBill_CustomEntity.BillApprovalStatusID = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID); }
            if (reader.IsDBNull(FLD_STARTDATE)) { aCCPrePayableStatementDetailByBill_CustomEntity.StartDate = null; } else { aCCPrePayableStatementDetailByBill_CustomEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }

            return aCCPrePayableStatementDetailByBill_CustomEntity;
        }
    }
}
