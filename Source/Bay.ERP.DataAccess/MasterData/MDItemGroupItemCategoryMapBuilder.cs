// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDItemGroupItemCategoryMapBuilder : IEntityBuilder<MDItemGroupItemCategoryMapEntity>
    {
        IList<MDItemGroupItemCategoryMapEntity> IEntityBuilder<MDItemGroupItemCategoryMapEntity>.BuildEntities(IDataReader reader)
        {
            List<MDItemGroupItemCategoryMapEntity> MDItemGroupItemCategoryMapEntityList = new List<MDItemGroupItemCategoryMapEntity>();

            while (reader.Read())
            {
                MDItemGroupItemCategoryMapEntityList.Add(((IEntityBuilder<MDItemGroupItemCategoryMapEntity>)this).BuildEntity(reader));
            }

            return (MDItemGroupItemCategoryMapEntityList.Count > 0) ? MDItemGroupItemCategoryMapEntityList : null;
        }

        MDItemGroupItemCategoryMapEntity IEntityBuilder<MDItemGroupItemCategoryMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ITEMGROUPITEMCATEGORYMAPID = 0;
            const Int32 FLD_ITEMGROUPID = 1;
            const Int32 FLD_ITEMCATEGORYID = 2;

            MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity = new MDItemGroupItemCategoryMapEntity();

            mDItemGroupItemCategoryMapEntity.ItemGroupItemCategoryMapID = reader.GetInt64(FLD_ITEMGROUPITEMCATEGORYMAPID);
            mDItemGroupItemCategoryMapEntity.ItemGroupID = reader.GetInt64(FLD_ITEMGROUPID);
            mDItemGroupItemCategoryMapEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);

            return mDItemGroupItemCategoryMapEntity;
        }
    }
}
