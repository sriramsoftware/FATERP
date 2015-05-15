// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDEventInvitatedPersonTypeBuilder : IEntityBuilder<MDEventInvitatedPersonTypeEntity>
    {
        IList<MDEventInvitatedPersonTypeEntity> IEntityBuilder<MDEventInvitatedPersonTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEventInvitatedPersonTypeEntity> MDEventInvitatedPersonTypeEntityList = new List<MDEventInvitatedPersonTypeEntity>();

            while (reader.Read())
            {
                MDEventInvitatedPersonTypeEntityList.Add(((IEntityBuilder<MDEventInvitatedPersonTypeEntity>)this).BuildEntity(reader));
            }

            return (MDEventInvitatedPersonTypeEntityList.Count > 0) ? MDEventInvitatedPersonTypeEntityList : null;
        }

        MDEventInvitatedPersonTypeEntity IEntityBuilder<MDEventInvitatedPersonTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EVENTINVITATEDPERSONTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity = new MDEventInvitatedPersonTypeEntity();

            mDEventInvitatedPersonTypeEntity.EventInvitatedPersonTypeID = reader.GetInt64(FLD_EVENTINVITATEDPERSONTYPEID);
            mDEventInvitatedPersonTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDEventInvitatedPersonTypeEntity.Remarks = String.Empty; } else { mDEventInvitatedPersonTypeEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDEventInvitatedPersonTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEventInvitatedPersonTypeEntity;
        }
    }
}
