// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Feb-2013, 03:00:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACMDAccountResourceCategoryBuilder : IEntityBuilder<ACMDAccountResourceCategoryEntity>
    {
        IList<ACMDAccountResourceCategoryEntity> IEntityBuilder<ACMDAccountResourceCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<ACMDAccountResourceCategoryEntity> ACMDAccountResourceCategoryEntityList = new List<ACMDAccountResourceCategoryEntity>();

            while (reader.Read())
            {
                ACMDAccountResourceCategoryEntityList.Add(((IEntityBuilder<ACMDAccountResourceCategoryEntity>)this).BuildEntity(reader));
            }

            return (ACMDAccountResourceCategoryEntityList.Count > 0) ? ACMDAccountResourceCategoryEntityList : null;
        }

        ACMDAccountResourceCategoryEntity IEntityBuilder<ACMDAccountResourceCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTRESOURCECATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACMDAccountResourceCategoryEntity aCMDAccountResourceCategoryEntity = new ACMDAccountResourceCategoryEntity();

            aCMDAccountResourceCategoryEntity.AccountResourceCategoryID = reader.GetInt64(FLD_ACCOUNTRESOURCECATEGORYID);
            aCMDAccountResourceCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCMDAccountResourceCategoryEntity.Description = String.Empty; } else { aCMDAccountResourceCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCMDAccountResourceCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCMDAccountResourceCategoryEntity;
        }
    }
}
