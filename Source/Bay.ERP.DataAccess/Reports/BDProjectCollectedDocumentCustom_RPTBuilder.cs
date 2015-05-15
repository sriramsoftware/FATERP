// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jul-2013, 10:34:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDProjectCollectedDocumentCustom_RPTBuilder : IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>
    {
        IList<BDProjectCollectedDocumentCustom_RPTEntity> IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<BDProjectCollectedDocumentCustom_RPTEntity> BDProjectCollectedDocumentCustom_RPTEntityList = new List<BDProjectCollectedDocumentCustom_RPTEntity>();

            while (reader.Read())
            {
                BDProjectCollectedDocumentCustom_RPTEntityList.Add(((IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>)this).BuildEntity(reader));
            }

            return (BDProjectCollectedDocumentCustom_RPTEntityList.Count > 0) ? BDProjectCollectedDocumentCustom_RPTEntityList : null;
        }

        BDProjectCollectedDocumentCustom_RPTEntity IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROJECTID = 0;
            const Int32 FLD_PROJECTCODE = 1;
            const Int32 FLD_PROJECTNAME = 2;
            const Int32 FLD_LANDAREAKATHA = 3;
            const Int32 FLD_LANDAREASFT = 4;
            const Int32 FLD_ROADWIDTH = 5;
            const Int32 FLD_ROADWIDTHUNITID = 6;
            const Int32 FLD_NOOFSTORIED = 7;
            const Int32 FLD_NOOFBASEMENT = 8;
            const Int32 FLD_DESCRIPTION = 9;
            const Int32 FLD_CLIENTPERCENTAGE = 10;
            const Int32 FLD_COMPANYPERCENTAGE = 11;
            const Int32 FLD_PROJECTCATEGORYID = 12;
            const Int32 FLD_PROJECTSTATUSID = 13;
            const Int32 FLD_PROJECTDOCUMENTNAME = 14;
            const Int32 FLD_STARTDATE = 15;
            const Int32 FLD_REQUIREDTIME = 16;
            const Int32 FLD_REQUIREDTIMEUNIT = 17;
            const Int32 FLD_PROJECTDOCUMENTSTATUSNAME = 18;

            BDProjectCollectedDocumentCustom_RPTEntity bDProjectCollectedDocumentCustom_RPTEntity = new BDProjectCollectedDocumentCustom_RPTEntity();

            bDProjectCollectedDocumentCustom_RPTEntity.ProjectID = reader.GetInt64(FLD_PROJECTID);
            bDProjectCollectedDocumentCustom_RPTEntity.ProjectCode = reader.GetString(FLD_PROJECTCODE);
            bDProjectCollectedDocumentCustom_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME);
            if (reader.IsDBNull(FLD_LANDAREAKATHA)) { bDProjectCollectedDocumentCustom_RPTEntity.LandAreaKatha = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.LandAreaKatha = reader.GetDecimal(FLD_LANDAREAKATHA); }
            if (reader.IsDBNull(FLD_LANDAREASFT)) { bDProjectCollectedDocumentCustom_RPTEntity.LandAreaSft = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.LandAreaSft = reader.GetDecimal(FLD_LANDAREASFT); }
            if (reader.IsDBNull(FLD_ROADWIDTH)) { bDProjectCollectedDocumentCustom_RPTEntity.RoadWidth = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.RoadWidth = reader.GetDecimal(FLD_ROADWIDTH); }
            if (reader.IsDBNull(FLD_ROADWIDTHUNITID)) { bDProjectCollectedDocumentCustom_RPTEntity.RoadWidthUnitID = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.RoadWidthUnitID = reader.GetInt64(FLD_ROADWIDTHUNITID); }
            if (reader.IsDBNull(FLD_NOOFSTORIED)) { bDProjectCollectedDocumentCustom_RPTEntity.NoOfStoried = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.NoOfStoried = reader.GetInt32(FLD_NOOFSTORIED); }
            if (reader.IsDBNull(FLD_NOOFBASEMENT)) { bDProjectCollectedDocumentCustom_RPTEntity.NoOfBasement = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.NoOfBasement = reader.GetInt32(FLD_NOOFBASEMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { bDProjectCollectedDocumentCustom_RPTEntity.Description = String.Empty; } else { bDProjectCollectedDocumentCustom_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            if (reader.IsDBNull(FLD_CLIENTPERCENTAGE)) { bDProjectCollectedDocumentCustom_RPTEntity.ClientPercentage = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.ClientPercentage = reader.GetDecimal(FLD_CLIENTPERCENTAGE); }
            if (reader.IsDBNull(FLD_COMPANYPERCENTAGE)) { bDProjectCollectedDocumentCustom_RPTEntity.CompanyPercentage = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.CompanyPercentage = reader.GetDecimal(FLD_COMPANYPERCENTAGE); }
            bDProjectCollectedDocumentCustom_RPTEntity.ProjectCategoryID = reader.GetInt64(FLD_PROJECTCATEGORYID);
            bDProjectCollectedDocumentCustom_RPTEntity.ProjectStatusID = reader.GetInt64(FLD_PROJECTSTATUSID);
            if (reader.IsDBNull(FLD_PROJECTDOCUMENTNAME)) { bDProjectCollectedDocumentCustom_RPTEntity.ProjectDocumentName = String.Empty; } else { bDProjectCollectedDocumentCustom_RPTEntity.ProjectDocumentName = reader.GetString(FLD_PROJECTDOCUMENTNAME); }
            if (reader.IsDBNull(FLD_STARTDATE)) { bDProjectCollectedDocumentCustom_RPTEntity.StartDate = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.StartDate = reader.GetDateTime(FLD_STARTDATE); }
            if (reader.IsDBNull(FLD_REQUIREDTIME)) { bDProjectCollectedDocumentCustom_RPTEntity.RequiredTime = null; } else { bDProjectCollectedDocumentCustom_RPTEntity.RequiredTime = reader.GetInt32(FLD_REQUIREDTIME); }
            if (reader.IsDBNull(FLD_REQUIREDTIMEUNIT)) { bDProjectCollectedDocumentCustom_RPTEntity.RequiredTimeUnit = String.Empty; } else { bDProjectCollectedDocumentCustom_RPTEntity.RequiredTimeUnit = reader.GetString(FLD_REQUIREDTIMEUNIT); }
            if (reader.IsDBNull(FLD_PROJECTDOCUMENTSTATUSNAME)) { bDProjectCollectedDocumentCustom_RPTEntity.ProjectDocumentStatusName = String.Empty; } else { bDProjectCollectedDocumentCustom_RPTEntity.ProjectDocumentStatusName = reader.GetString(FLD_PROJECTDOCUMENTSTATUSNAME); }

            return bDProjectCollectedDocumentCustom_RPTEntity;
        }
    }
}
