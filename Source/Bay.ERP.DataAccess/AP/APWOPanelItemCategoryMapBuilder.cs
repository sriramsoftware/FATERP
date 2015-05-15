// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 10:59:14




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class APWOPanelItemCategoryMapBuilder : IEntityBuilder<APWOPanelItemCategoryMapEntity>
    {
        IList<APWOPanelItemCategoryMapEntity> IEntityBuilder<APWOPanelItemCategoryMapEntity>.BuildEntities(IDataReader reader)
        {
            List<APWOPanelItemCategoryMapEntity> APWOPanelItemCategoryMapEntityList = new List<APWOPanelItemCategoryMapEntity>();

            while (reader.Read())
            {
                APWOPanelItemCategoryMapEntityList.Add(((IEntityBuilder<APWOPanelItemCategoryMapEntity>)this).BuildEntity(reader));
            }

            return (APWOPanelItemCategoryMapEntityList.Count > 0) ? APWOPanelItemCategoryMapEntityList : null;
        }

        APWOPanelItemCategoryMapEntity IEntityBuilder<APWOPanelItemCategoryMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APWOPANELITEMCATEGORYMAPID = 0;
            const Int32 FLD_APPANELID = 1;
            const Int32 FLD_ITEMCATEGORYID = 2;

            APWOPanelItemCategoryMapEntity aPWOPanelItemCategoryMapEntity = new APWOPanelItemCategoryMapEntity();

            aPWOPanelItemCategoryMapEntity.APWOPanelItemCategoryMapID = reader.GetInt64(FLD_APWOPANELITEMCATEGORYMAPID);
            aPWOPanelItemCategoryMapEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPWOPanelItemCategoryMapEntity.ItemCategoryID = reader.GetInt64(FLD_ITEMCATEGORYID);

            return aPWOPanelItemCategoryMapEntity;
        }
    }
}
