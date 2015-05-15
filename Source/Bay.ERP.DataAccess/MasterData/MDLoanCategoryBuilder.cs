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
    internal sealed class MDLoanCategoryBuilder : IEntityBuilder<MDLoanCategoryEntity>
    {
        IList<MDLoanCategoryEntity> IEntityBuilder<MDLoanCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDLoanCategoryEntity> MDLoanCategoryEntityList = new List<MDLoanCategoryEntity>();

            while (reader.Read())
            {
                MDLoanCategoryEntityList.Add(((IEntityBuilder<MDLoanCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDLoanCategoryEntityList.Count > 0) ? MDLoanCategoryEntityList : null;
        }

        MDLoanCategoryEntity IEntityBuilder<MDLoanCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LOANCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;

            MDLoanCategoryEntity mDLoanCategoryEntity = new MDLoanCategoryEntity();

            mDLoanCategoryEntity.LoanCategoryID = reader.GetInt64(FLD_LOANCATEGORYID);
            mDLoanCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDLoanCategoryEntity.Description = String.Empty; } else { mDLoanCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return mDLoanCategoryEntity;
        }
    }
}
