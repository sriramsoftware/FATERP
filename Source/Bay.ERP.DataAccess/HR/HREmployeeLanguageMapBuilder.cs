// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLanguageMapBuilder : IEntityBuilder<HREmployeeLanguageMapEntity>
    {
        IList<HREmployeeLanguageMapEntity> IEntityBuilder<HREmployeeLanguageMapEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLanguageMapEntity> HREmployeeLanguageMapEntityList = new List<HREmployeeLanguageMapEntity>();

            while (reader.Read())
            {
                HREmployeeLanguageMapEntityList.Add(((IEntityBuilder<HREmployeeLanguageMapEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLanguageMapEntityList.Count > 0) ? HREmployeeLanguageMapEntityList : null;
        }

        HREmployeeLanguageMapEntity IEntityBuilder<HREmployeeLanguageMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELANGUAGEMAPID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEELANGUAGEID = 2;
            const Int32 FLD_EMPLOYEECOMPETENCYLEVELID = 3;
            const Int32 FLD_REMARKS = 4;

            HREmployeeLanguageMapEntity hREmployeeLanguageMapEntity = new HREmployeeLanguageMapEntity();

            hREmployeeLanguageMapEntity.EmployeeLanguageMapID = reader.GetInt64(FLD_EMPLOYEELANGUAGEMAPID);
            hREmployeeLanguageMapEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLanguageMapEntity.EmployeeLanguageID = reader.GetInt64(FLD_EMPLOYEELANGUAGEID);
            hREmployeeLanguageMapEntity.EmployeeCompetencyLevelID = reader.GetInt64(FLD_EMPLOYEECOMPETENCYLEVELID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeLanguageMapEntity.Remarks = String.Empty; } else { hREmployeeLanguageMapEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeLanguageMapEntity;
        }
    }
}
