// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 10:45:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using System.Data.SqlClient;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueCategoryWise_RPTBuilder : IEntityBuilder<OTIssueCategoryWise_RPTEntity>
    {
        IList<OTIssueCategoryWise_RPTEntity> IEntityBuilder<OTIssueCategoryWise_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueCategoryWise_RPTEntity> OTIssueCategoryWise_RPTEntityList = new List<OTIssueCategoryWise_RPTEntity>();

            while (reader.Read())
            {
                OTIssueCategoryWise_RPTEntityList.Add(((IEntityBuilder<OTIssueCategoryWise_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTIssueCategoryWise_RPTEntityList.Count > 0) ? OTIssueCategoryWise_RPTEntityList : null;
        }

        OTIssueCategoryWise_RPTEntity IEntityBuilder<OTIssueCategoryWise_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUECATEGORYID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_PROJECTNAME = 3;
            const Int32 FLD_TOTALTIME = 4;

            OTIssueCategoryWise_RPTEntity oTIssueCategoryWise_RPTEntity = new OTIssueCategoryWise_RPTEntity();

            oTIssueCategoryWise_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssueCategoryWise_RPTEntity.ReferenceID = null; } else { oTIssueCategoryWise_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssueCategoryWise_RPTEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssueCategoryWise_RPTEntity.ProjectName = String.Empty; } else { oTIssueCategoryWise_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            //if (reader.IsDBNull(FLD_TOTALTIME)) { oTIssueCategoryWise_RPTEntity.TotalTime = null; } else { oTIssueCategoryWise_RPTEntity.TotalTime = ((SqlDataReader)reader).GetTimeSpan(FLD_TOTALTIME); }
            if (reader.IsDBNull(FLD_TOTALTIME)) { oTIssueCategoryWise_RPTEntity.TotalTime = null; } else { oTIssueCategoryWise_RPTEntity.TotalTime =reader.GetString(FLD_TOTALTIME); }

            return oTIssueCategoryWise_RPTEntity;
        }
    }
}
