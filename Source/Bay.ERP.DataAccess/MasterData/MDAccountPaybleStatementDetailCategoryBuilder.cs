// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDAccountPaybleStatementDetailCategoryBuilder : IEntityBuilder<MDAccountPaybleStatementDetailCategoryEntity>
    {
        IList<MDAccountPaybleStatementDetailCategoryEntity> IEntityBuilder<MDAccountPaybleStatementDetailCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDAccountPaybleStatementDetailCategoryEntity> MDAccountPaybleStatementDetailCategoryEntityList = new List<MDAccountPaybleStatementDetailCategoryEntity>();

            while (reader.Read())
            {
                MDAccountPaybleStatementDetailCategoryEntityList.Add(((IEntityBuilder<MDAccountPaybleStatementDetailCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDAccountPaybleStatementDetailCategoryEntityList.Count > 0) ? MDAccountPaybleStatementDetailCategoryEntityList : null;
        }

        MDAccountPaybleStatementDetailCategoryEntity IEntityBuilder<MDAccountPaybleStatementDetailCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDAccountPaybleStatementDetailCategoryEntity mDAccountPaybleStatementDetailCategoryEntity = new MDAccountPaybleStatementDetailCategoryEntity();

            mDAccountPaybleStatementDetailCategoryEntity.AccountPaybleStatementDetailCategoryID = reader.GetInt64(FLD_ACCOUNTPAYBLESTATEMENTDETAILCATEGORYID);
            mDAccountPaybleStatementDetailCategoryEntity.Name = reader.GetString(FLD_NAME);
            mDAccountPaybleStatementDetailCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDAccountPaybleStatementDetailCategoryEntity;
        }
    }
}
