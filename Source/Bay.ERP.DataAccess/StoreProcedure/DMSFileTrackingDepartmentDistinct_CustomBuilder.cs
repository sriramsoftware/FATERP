// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Sep-2012, 02:08:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSFileTrackingDepartmentDistinct_CustomBuilder : IEntityBuilder<DMSFileTrackingDepartmentDistinct_CustomEntity>
    {
        IList<DMSFileTrackingDepartmentDistinct_CustomEntity> IEntityBuilder<DMSFileTrackingDepartmentDistinct_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSFileTrackingDepartmentDistinct_CustomEntity> DMSFileTrackingDepartmentDistinct_CustomEntityList = new List<DMSFileTrackingDepartmentDistinct_CustomEntity>();

            while (reader.Read())
            {
                DMSFileTrackingDepartmentDistinct_CustomEntityList.Add(((IEntityBuilder<DMSFileTrackingDepartmentDistinct_CustomEntity>)this).BuildEntity(reader));
            }

            return (DMSFileTrackingDepartmentDistinct_CustomEntityList.Count > 0) ? DMSFileTrackingDepartmentDistinct_CustomEntityList : null;
        }

        DMSFileTrackingDepartmentDistinct_CustomEntity IEntityBuilder<DMSFileTrackingDepartmentDistinct_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DEPARTMENTID = 0;
            const Int32 FLD_DEPARTMENTNAME = 1;

            DMSFileTrackingDepartmentDistinct_CustomEntity dMSFileTrackingDepartmentDistinct_CustomEntity = new DMSFileTrackingDepartmentDistinct_CustomEntity();

            dMSFileTrackingDepartmentDistinct_CustomEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            dMSFileTrackingDepartmentDistinct_CustomEntity.DepartmentName = reader.GetString(FLD_DEPARTMENTNAME);

            return dMSFileTrackingDepartmentDistinct_CustomEntity;
        }
    }
}
