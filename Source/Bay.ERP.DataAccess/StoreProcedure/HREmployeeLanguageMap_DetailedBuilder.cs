// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLanguageMap_DetailedBuilder : IEntityBuilder<HREmployeeLanguageMap_DetailedEntity>
    {
        IList<HREmployeeLanguageMap_DetailedEntity> IEntityBuilder<HREmployeeLanguageMap_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLanguageMap_DetailedEntity> HREmployeeLanguageMap_DetailedEntityList = new List<HREmployeeLanguageMap_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeLanguageMap_DetailedEntityList.Add(((IEntityBuilder<HREmployeeLanguageMap_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLanguageMap_DetailedEntityList.Count > 0) ? HREmployeeLanguageMap_DetailedEntityList : null;
        }

        HREmployeeLanguageMap_DetailedEntity IEntityBuilder<HREmployeeLanguageMap_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELANGUAGEMAPID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEELANGUAGEID = 2;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELID = 3;
            const Int32 FLD_REMARKS = 4;
            const Int32 FLD_EMPLOYEEFULLNAME = 5;
            const Int32 FLD_EMPLOYEELANGUAGENAME = 6;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELNAME = 7;
            const Int32 FLD_ROWNUMBER = 8;

            HREmployeeLanguageMap_DetailedEntity hREmployeeLanguageMap_DetailedEntity = new HREmployeeLanguageMap_DetailedEntity();

            hREmployeeLanguageMap_DetailedEntity.EmployeeLanguageMapID = reader.GetInt64(FLD_EMPLOYEELANGUAGEMAPID);
            hREmployeeLanguageMap_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLanguageMap_DetailedEntity.EmployeeLanguageID = reader.GetInt64(FLD_EMPLOYEELANGUAGEID);
            hREmployeeLanguageMap_DetailedEntity.EmployeeCompetencyLevelID = reader.GetInt64(FLD_EMPLOYEECOMPETENCYLEVELID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeLanguageMap_DetailedEntity.Remarks = String.Empty; } else { hREmployeeLanguageMap_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeLanguageMap_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeLanguageMap_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELANGUAGENAME)) { hREmployeeLanguageMap_DetailedEntity.EmployeeLanguageName = String.Empty; } else { hREmployeeLanguageMap_DetailedEntity.EmployeeLanguageName = reader.GetString(FLD_EMPLOYEELANGUAGENAME); }
            if (reader.IsDBNull(FLD_EMPLOYEECOMPETENCYLEVELNAME)) { hREmployeeLanguageMap_DetailedEntity.EmployeeCompetencyLevelName = String.Empty; } else { hREmployeeLanguageMap_DetailedEntity.EmployeeCompetencyLevelName = reader.GetString(FLD_EMPLOYEECOMPETENCYLEVELNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeLanguageMap_DetailedEntity.RowNumber = null; } else { hREmployeeLanguageMap_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeLanguageMap_DetailedEntity;
        }
    }
}
