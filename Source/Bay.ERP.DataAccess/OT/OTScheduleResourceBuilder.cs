// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class OTScheduleResourceBuilder : IEntityBuilder<OTScheduleResourceEntity>
    {
        IList<OTScheduleResourceEntity> IEntityBuilder<OTScheduleResourceEntity>.BuildEntities(IDataReader reader)
        {
            List<OTScheduleResourceEntity> OTScheduleResourceEntityList = new List<OTScheduleResourceEntity>();

            while (reader.Read())
            {
                OTScheduleResourceEntityList.Add(((IEntityBuilder<OTScheduleResourceEntity>)this).BuildEntity(reader));
            }

            return (OTScheduleResourceEntityList.Count > 0) ? OTScheduleResourceEntityList : null;
        }

        OTScheduleResourceEntity IEntityBuilder<OTScheduleResourceEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OTSCHEDULERESOURCEID = 0;
            const Int32 FLD_SCHEDULEID = 1;
            const Int32 FLD_RESOURCEID = 2;

            OTScheduleResourceEntity oTScheduleResourceEntity = new OTScheduleResourceEntity();

            oTScheduleResourceEntity.OTScheduleResourceID = reader.GetInt64(FLD_OTSCHEDULERESOURCEID);
            oTScheduleResourceEntity.ScheduleID = reader.GetInt64(FLD_SCHEDULEID);
            oTScheduleResourceEntity.ResourceID = reader.GetInt64(FLD_RESOURCEID);

            return oTScheduleResourceEntity;
        }
    }
}
