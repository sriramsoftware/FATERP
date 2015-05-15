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
    internal sealed class APPanelBuilder : IEntityBuilder<APPanelEntity>
    {
        IList<APPanelEntity> IEntityBuilder<APPanelEntity>.BuildEntities(IDataReader reader)
        {
            List<APPanelEntity> APPanelEntityList = new List<APPanelEntity>();

            while (reader.Read())
            {
                APPanelEntityList.Add(((IEntityBuilder<APPanelEntity>)this).BuildEntity(reader));
            }

            return (APPanelEntityList.Count > 0) ? APPanelEntityList : null;
        }

        APPanelEntity IEntityBuilder<APPanelEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_APPANELID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            APPanelEntity aPPanelEntity = new APPanelEntity();

            aPPanelEntity.APPanelID = reader.GetInt64(FLD_APPANELID);
            aPPanelEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aPPanelEntity.Description = String.Empty; } else { aPPanelEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aPPanelEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aPPanelEntity;
        }
    }
}
