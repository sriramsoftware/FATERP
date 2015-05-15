// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Sep-2013, 04:16:48




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTIssueCategoryWiseIndividual_RPTBuilder : IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>
    {
        IList<OTIssueCategoryWiseIndividual_RPTEntity> IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<OTIssueCategoryWiseIndividual_RPTEntity> OTIssueCategoryWiseIndividual_RPTEntityList = new List<OTIssueCategoryWiseIndividual_RPTEntity>();

            while (reader.Read())
            {
                OTIssueCategoryWiseIndividual_RPTEntityList.Add(((IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>)this).BuildEntity(reader));
            }

            return (OTIssueCategoryWiseIndividual_RPTEntityList.Count > 0) ? OTIssueCategoryWiseIndividual_RPTEntityList : null;
        }

        OTIssueCategoryWiseIndividual_RPTEntity IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ISSUECATEGORYID = 0;
            const Int32 FLD_REFERENCEID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_ASSIGNEDPERSONEMPLOYEECODE = 3;
            const Int32 FLD_ASSIGNEDPERSONDESIGNATIONNAME = 4;
            const Int32 FLD_ASSIGNEDPERSONDEPARTMENTNAME = 5;
            const Int32 FLD_ASSIGNEDTOEMPLOYEEFULLNAME = 6;
            const Int32 FLD_PROJECTNAME = 7;
            const Int32 FLD_TOTALTIME = 8;

            OTIssueCategoryWiseIndividual_RPTEntity oTIssueCategoryWiseIndividual_RPTEntity = new OTIssueCategoryWiseIndividual_RPTEntity();

            oTIssueCategoryWiseIndividual_RPTEntity.IssueCategoryID = reader.GetInt64(FLD_ISSUECATEGORYID);
            if (reader.IsDBNull(FLD_REFERENCEID)) { oTIssueCategoryWiseIndividual_RPTEntity.ReferenceID = null; } else { oTIssueCategoryWiseIndividual_RPTEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID); }
            oTIssueCategoryWiseIndividual_RPTEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONEMPLOYEECODE)) { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonEmployeeCode = String.Empty; } else { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonEmployeeCode = reader.GetString(FLD_ASSIGNEDPERSONEMPLOYEECODE); }
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONDESIGNATIONNAME)) { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonDesignationName = String.Empty; } else { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonDesignationName = reader.GetString(FLD_ASSIGNEDPERSONDESIGNATIONNAME); }
            if (reader.IsDBNull(FLD_ASSIGNEDPERSONDEPARTMENTNAME)) { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonDepartmentName = String.Empty; } else { oTIssueCategoryWiseIndividual_RPTEntity.AssignedPersonDepartmentName = reader.GetString(FLD_ASSIGNEDPERSONDEPARTMENTNAME); }
            if (reader.IsDBNull(FLD_ASSIGNEDTOEMPLOYEEFULLNAME)) { oTIssueCategoryWiseIndividual_RPTEntity.AssignedToEmployeeFullName = String.Empty; } else { oTIssueCategoryWiseIndividual_RPTEntity.AssignedToEmployeeFullName = reader.GetString(FLD_ASSIGNEDTOEMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { oTIssueCategoryWiseIndividual_RPTEntity.ProjectName = String.Empty; } else { oTIssueCategoryWiseIndividual_RPTEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_TOTALTIME)) { oTIssueCategoryWiseIndividual_RPTEntity.TotalTime = null; } else { oTIssueCategoryWiseIndividual_RPTEntity.TotalTime = reader.GetInt32(FLD_TOTALTIME); }

            return oTIssueCategoryWiseIndividual_RPTEntity;
        }
    }
}
