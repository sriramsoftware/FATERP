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
    internal sealed class HREmployeeJobDescriptionBuilder : IEntityBuilder<HREmployeeJobDescriptionEntity>
    {
        IList<HREmployeeJobDescriptionEntity> IEntityBuilder<HREmployeeJobDescriptionEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeJobDescriptionEntity> HREmployeeJobDescriptionEntityList = new List<HREmployeeJobDescriptionEntity>();

            while (reader.Read())
            {
                HREmployeeJobDescriptionEntityList.Add(((IEntityBuilder<HREmployeeJobDescriptionEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeJobDescriptionEntityList.Count > 0) ? HREmployeeJobDescriptionEntityList : null;
        }

        HREmployeeJobDescriptionEntity IEntityBuilder<HREmployeeJobDescriptionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEJOBDESCRIPTIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_CREATEDATE = 4;

            HREmployeeJobDescriptionEntity hREmployeeJobDescriptionEntity = new HREmployeeJobDescriptionEntity();

            hREmployeeJobDescriptionEntity.EmployeeJobDescriptionID = reader.GetInt64(FLD_EMPLOYEEJOBDESCRIPTIONID);
            hREmployeeJobDescriptionEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeJobDescriptionEntity.Description = reader.GetString(FLD_DESCRIPTION);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeJobDescriptionEntity.Remarks = String.Empty; } else { hREmployeeJobDescriptionEntity.Remarks = reader.GetString(FLD_REMARKS); }
            hREmployeeJobDescriptionEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);

            return hREmployeeJobDescriptionEntity;
        }
    }
}
