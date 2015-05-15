// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APPanelItemCategoryMapBuilder : IEntityBuilder<APPanelItemCategoryMapEntity>
    {
        IList<APPanelItemCategoryMapEntity> IEntityBuilder<APPanelItemCategoryMapEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelItemCategoryMapEntity> APPanelItemCategoryMapEntityList = new List<APPanelItemCategoryMapEntity>();

            while (reader.Read())
            {
                APPanelItemCategoryMapEntityList.Add(((IEntityBuilder<APPanelItemCategoryMapEntity>)this).BuildEntity(reader));
            }

            return (APPanelItemCategoryMapEntityList.Count > 0) ? APPanelItemCategoryMapEntityList : null;
        }

        APPanelItemCategoryMapEntity IEntityBuilder<APPanelItemCategoryMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELITEMCATEGORYMAPID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_ITEMCATEGORYID = 2;

            APPanelItemCategoryMapEntity aPPanelItemCategoryMapEntity = new APPanelItemCategoryMapEntity();

            aPPanelItemCategoryMapEntity.APPanelItemCategoryMapID = reader.GetInt64(FLD_APPANELITEMCATEGORYMAPID);
            aPPanelItemCategoryMapEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelItemCategoryMapEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);

            return aPPanelItemCategoryMapEntity;
        }
    }
}
