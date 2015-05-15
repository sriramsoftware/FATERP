// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 09:48:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APPanelItemCategoryMap_CustomBuilder : IEntityBuilder<APPanelItemCategoryMap_CustomEntity>
    {
        IList<APPanelItemCategoryMap_CustomEntity> IEntityBuilder<APPanelItemCategoryMap_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelItemCategoryMap_CustomEntity> APPanelItemCategoryMap_CustomEntityList = new List<APPanelItemCategoryMap_CustomEntity>();

            while (reader.Read())
            {
                APPanelItemCategoryMap_CustomEntityList.Add(((IEntityBuilder<APPanelItemCategoryMap_CustomEntity>)this).BuildEntity(reader));
            }

            return (APPanelItemCategoryMap_CustomEntityList.Count > 0) ? APPanelItemCategoryMap_CustomEntityList : null;
        }

        APPanelItemCategoryMap_CustomEntity IEntityBuilder<APPanelItemCategoryMap_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELITEMCATEGORYMAPID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_ITEMCATEGORYID = 2;
            const Int32 FLD_PANELNAME = 3;
            const Int32 FLD_ITEMCATEGORYNAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            APPanelItemCategoryMap_CustomEntity aPPanelItemCategoryMap_CustomEntity = new APPanelItemCategoryMap_CustomEntity();

            aPPanelItemCategoryMap_CustomEntity.APPanelItemCategoryMapID = reader.GetInt64(FLD_APPANELITEMCATEGORYMAPID);
            aPPanelItemCategoryMap_CustomEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelItemCategoryMap_CustomEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);
            if (reader.IsDBNull(FLD_PANELNAME)) { aPPanelItemCategoryMap_CustomEntity.PanelName = String.Empty; } else { aPPanelItemCategoryMap_CustomEntity.PanelName = reader.GetString(FLD_PANELNAME); }
            if (reader.IsDBNull(FLD_ITEMCATEGORYNAME)) { aPPanelItemCategoryMap_CustomEntity.ItemCategoryName = String.Empty; } else { aPPanelItemCategoryMap_CustomEntity.ItemCategoryName = reader.GetString(FLD_ITEMCATEGORYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aPPanelItemCategoryMap_CustomEntity.RowNumber = null; } else { aPPanelItemCategoryMap_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aPPanelItemCategoryMap_CustomEntity;
        }
    }
}
