// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2013, 01:29:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMApprovedBillExceptACCPrePayable_CustomBuilder : IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>
    {
        IList<CMApprovedBillExceptACCPrePayable_CustomEntity> IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CMApprovedBillExceptACCPrePayable_CustomEntity> CMApprovedBillExceptACCPrePayable_CustomEntityList = new List<CMApprovedBillExceptACCPrePayable_CustomEntity>();

            while (reader.Read())
            {
                CMApprovedBillExceptACCPrePayable_CustomEntityList.Add(((IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>)this).BuildEntity(reader));
            }

            return (CMApprovedBillExceptACCPrePayable_CustomEntityList.Count > 0) ? CMApprovedBillExceptACCPrePayable_CustomEntityList : null;
        }

        CMApprovedBillExceptACCPrePayable_CustomEntity IEntityBuilder<CMApprovedBillExceptACCPrePayable_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BILLID = 0;
            const Int32 FLD_BILLNO = 1;
            const Int32 FLD_BILLDATE = 2;
            const Int32 FLD_AMOUNT = 3;
            const Int32 FLD_PROJECTID = 4;
            const Int32 FLD_VENDORCATEGORY = 5;
            const Int32 FLD_VENDOR = 6;
            const Int32 FLD_BILLSTATUSID = 7;
            const Int32 FLD_BILLAPPROVALSTATUSID = 8;

            CMApprovedBillExceptACCPrePayable_CustomEntity cMApprovedBillExceptACCPrePayable_CustomEntity = new CMApprovedBillExceptACCPrePayable_CustomEntity();

            cMApprovedBillExceptACCPrePayable_CustomEntity.BillID = reader.GetInt64(FLD_BILLID);
            cMApprovedBillExceptACCPrePayable_CustomEntity.BillNo = reader.GetString(FLD_BILLNO);
            cMApprovedBillExceptACCPrePayable_CustomEntity.BillDate = reader.GetDateTime(FLD_BILLDATE);
            cMApprovedBillExceptACCPrePayable_CustomEntity.Amount = reader.GetDecimal(FLD_AMOUNT);
            cMApprovedBillExceptACCPrePayable_CustomEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            cMApprovedBillExceptACCPrePayable_CustomEntity.VendorCategory = reader.GetInt64(FLD_VENDORCATEGORY);
            cMApprovedBillExceptACCPrePayable_CustomEntity.Vendor = reader.GetInt64(FLD_VENDOR);
            cMApprovedBillExceptACCPrePayable_CustomEntity.BillStatusID = reader.GetInt64(FLD_BILLSTATUSID);
            cMApprovedBillExceptACCPrePayable_CustomEntity.BillApprovalStatusID = reader.GetInt64(FLD_BILLAPPROVALSTATUSID);

            return cMApprovedBillExceptACCPrePayable_CustomEntity;
        }
    }
}
