// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDMDProcessCategoryBuilder : IEntityBuilder<BDMDProcessCategoryEntity>
    {
        IList<BDMDProcessCategoryEntity> IEntityBuilder<BDMDProcessCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<BDMDProcessCategoryEntity> BDMDProcessCategoryEntityList = new List<BDMDProcessCategoryEntity>();

            while (reader.Read())
            {
                BDMDProcessCategoryEntityList.Add(((IEntityBuilder<BDMDProcessCategoryEntity>)this).BuildEntity(reader));
            }

            return (BDMDProcessCategoryEntityList.Count > 0) ? BDMDProcessCategoryEntityList : null;
        }

        BDMDProcessCategoryEntity IEntityBuilder<BDMDProcessCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROCESSCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            BDMDProcessCategoryEntity bDMDProcessCategoryEntity = new BDMDProcessCategoryEntity();

            bDMDProcessCategoryEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            bDMDProcessCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDMDProcessCategoryEntity.Description = String.Empty; } else { bDMDProcessCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            bDMDProcessCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDMDProcessCategoryEntity;
        }
    }
}
