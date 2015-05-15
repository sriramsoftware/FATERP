// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssue_CustomBuilder : IEntityBuilder<OTIssue_CustomEntity>
    {
        IList<OTIssue_CustomEntity> IEntityBuilder<OTIssue_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssue_CustomEntity> OTIssue_CustomEntityList = new List<OTIssue_CustomEntity>();

            while (reader.Read())
            {
                OTIssue_CustomEntityList.Add(((IEntityBuilder<OTIssue_CustomEntity>)this).BuildEntity(reader));
            }

            return (OTIssue_CustomEntityList.Count > 0) ? OTIssue_CustomEntityList : null;
        }

        OTIssue_CustomEntity IEntityBuilder<OTIssue_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUEID = 0;
            const Int32 FLD_TITLE = 1;
            const Int32 FLD_RESOURCECATEGORYID = 2;
            const Int32 FLD_REFERENCEID = 3;
            const Int32 FLD_EMPLOYEEFULLNAME = 4;
            const Int32 FLD_SPECIFICATION = 5;
            const Int32 FLD_ROWNUMBER = 6;

            OTIssue_CustomEntity oTIssue_CustomEntity = new OTIssue_CustomEntity();

            oTIssue_CustomEntity.IssueID = reader.GetInt64(FLD_ISSUEID);
            oTIssue_CustomEntity.Title = reader.GetString(FLD_TITLE);
            if (reader.IsDBNull(FLD_RESOURCECATEGORYID)) { oTIssue_CustomEntity.ResourceCategoryID = null; } else { oTIssue_CustomEntity.ResourceCategoryID = reader.GetInt64(FLD_RESOURCECATEGORYID); }
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssue_CustomEntity.ReferenceID = null; } else { oTIssue_CustomEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { oTIssue_CustomEntity.EmployeeFullName = String.Empty; } else { oTIssue_CustomEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_SPECIFICATION)) { oTIssue_CustomEntity.Specification = String.Empty; } else { oTIssue_CustomEntity.Specification = reader.GetString(FLD_SPECIFICATION); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { oTIssue_CustomEntity.RowNumber = null; } else { oTIssue_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return oTIssue_CustomEntity;
        }
    }
}
