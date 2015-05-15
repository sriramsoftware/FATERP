// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalaryDeducationCategoryBuilder : IEntityBuilder<MDSalaryDeducationCategoryEntity>
    {
        IList<MDSalaryDeducationCategoryEntity> IEntityBuilder<MDSalaryDeducationCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalaryDeducationCategoryEntity> MDSalaryDeducationCategoryEntityList = new List<MDSalaryDeducationCategoryEntity>();

            while (reader.Read())
            {
                MDSalaryDeducationCategoryEntityList.Add(((IEntityBuilder<MDSalaryDeducationCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDSalaryDeducationCategoryEntityList.Count > 0) ? MDSalaryDeducationCategoryEntityList : null;
        }

        MDSalaryDeducationCategoryEntity IEntityBuilder<MDSalaryDeducationCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYDEDUCATIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDSalaryDeducationCategoryEntity mDSalaryDeducationCategoryEntity = new MDSalaryDeducationCategoryEntity();

            mDSalaryDeducationCategoryEntity.SalaryDeducationCategoryID = reader.GetInt64(FLD_SALARYDEDUCATIONCATEGORYID);
            mDSalaryDeducationCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDSalaryDeducationCategoryEntity.Description = String.Empty; } else { mDSalaryDeducationCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDSalaryDeducationCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSalaryDeducationCategoryEntity;
        }
    }
}
