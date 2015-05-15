// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 02:11:32




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APWOPanelItemCategoryMap_DetailedBuilder : IEntityBuilder<APWOPanelItemCategoryMap_DetailedEntity>
    {
        IList<APWOPanelItemCategoryMap_DetailedEntity> IEntityBuilder<APWOPanelItemCategoryMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<APWOPanelItemCategoryMap_DetailedEntity> APWOPanelItemCategoryMap_DetailedEntityList = new List<APWOPanelItemCategoryMap_DetailedEntity>();

            while (reader.Read())
            {
                APWOPanelItemCategoryMap_DetailedEntityList.Add(((IEntityBuilder<APWOPanelItemCategoryMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (APWOPanelItemCategoryMap_DetailedEntityList.Count > 0) ? APWOPanelItemCategoryMap_DetailedEntityList : null;
        }

        APWOPanelItemCategoryMap_DetailedEntity IEntityBuilder<APWOPanelItemCategoryMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APWOPANELITEMCATEGORYMAPID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_ITEMCATEGORYID = 2;
            const Int32 FLD_PANELNAME = 3;
            const Int32 FLD_CATEGORYNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            APWOPanelItemCategoryMap_DetailedEntity aPWOPanelItemCategoryMap_DetailedEntity = new APWOPanelItemCategoryMap_DetailedEntity();

            aPWOPanelItemCategoryMap_DetailedEntity.APWOPanelItemCategoryMapID = reader.GetInt64(FLD_APWOPANELITEMCATEGORYMAPID);
            aPWOPanelItemCategoryMap_DetailedEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPWOPanelItemCategoryMap_DetailedEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_PANELNAME)) { aPWOPanelItemCategoryMap_DetailedEntity.PanelName = String.Empty; } else { aPWOPanelItemCategoryMap_DetailedEntity.PanelName = reader.GetString(FLD_PANELNAME); }
            if (reader.IsDBNull(FLD_CATEGORYNAME)) { aPWOPanelItemCategoryMap_DetailedEntity.CategoryName = String.Empty; } else { aPWOPanelItemCategoryMap_DetailedEntity.CategoryName = reader.GetString(FLD_CATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPWOPanelItemCategoryMap_DetailedEntity.RowNumber = null; } else { aPWOPanelItemCategoryMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPWOPanelItemCategoryMap_DetailedEntity;
        }
    }
}
