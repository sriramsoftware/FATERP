// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEmployeeLoanApprovalStatusBuilder : IEntityBuilder<MDEmployeeLoanApprovalStatusEntity>
    {
        IList<MDEmployeeLoanApprovalStatusEntity> IEntityBuilder<MDEmployeeLoanApprovalStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeLoanApprovalStatusEntity> MDEmployeeLoanApprovalStatusEntityList = new List<MDEmployeeLoanApprovalStatusEntity>();

            while (reader.Read())
            {
                MDEmployeeLoanApprovalStatusEntityList.Add(((IEntityBuilder<MDEmployeeLoanApprovalStatusEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeLoanApprovalStatusEntityList.Count > 0) ? MDEmployeeLoanApprovalStatusEntityList : null;
        }

        MDEmployeeLoanApprovalStatusEntity IEntityBuilder<MDEmployeeLoanApprovalStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELOANAPPROVALSTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;

            MDEmployeeLoanApprovalStatusEntity mDEmployeeLoanApprovalStatusEntity = new MDEmployeeLoanApprovalStatusEntity();

            mDEmployeeLoanApprovalStatusEntity.EmployeeLoanApprovalStatusID = reader.GetInt64(FLD_EMPLOYEELOANAPPROVALSTATUSID);
            mDEmployeeLoanApprovalStatusEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeLoanApprovalStatusEntity.Description = String.Empty; } else { mDEmployeeLoanApprovalStatusEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return mDEmployeeLoanApprovalStatusEntity;
        }
    }
}
