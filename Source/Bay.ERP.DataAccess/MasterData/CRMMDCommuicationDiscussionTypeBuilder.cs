// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMMDCommuicationDiscussionTypeBuilder : IEntityBuilder<CRMMDCommuicationDiscussionTypeEntity>
    {
        IList<CRMMDCommuicationDiscussionTypeEntity> IEntityBuilder<CRMMDCommuicationDiscussionTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMMDCommuicationDiscussionTypeEntity> CRMMDCommuicationDiscussionTypeEntityList = new List<CRMMDCommuicationDiscussionTypeEntity>();

            while (reader.Read())
            {
                CRMMDCommuicationDiscussionTypeEntityList.Add(((IEntityBuilder<CRMMDCommuicationDiscussionTypeEntity>)this).BuildEntity(reader));
            }

            return (CRMMDCommuicationDiscussionTypeEntityList.Count > 0) ? CRMMDCommuicationDiscussionTypeEntityList : null;
        }

        CRMMDCommuicationDiscussionTypeEntity IEntityBuilder<CRMMDCommuicationDiscussionTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_COMMUICATIONDISCUSSIONTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            CRMMDCommuicationDiscussionTypeEntity cRMMDCommuicationDiscussionTypeEntity = new CRMMDCommuicationDiscussionTypeEntity();

            cRMMDCommuicationDiscussionTypeEntity.CommuicationDiscussionTypeID = reader.GetInt64(FLD_COMMUICATIONDISCUSSIONTYPEID);
            cRMMDCommuicationDiscussionTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { cRMMDCommuicationDiscussionTypeEntity.Description = String.Empty; } else { cRMMDCommuicationDiscussionTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            cRMMDCommuicationDiscussionTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cRMMDCommuicationDiscussionTypeEntity;
        }
    }
}
