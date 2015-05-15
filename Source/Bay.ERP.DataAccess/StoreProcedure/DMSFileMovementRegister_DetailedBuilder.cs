// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Sep-2012, 10:36:26




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSFileMovementRegister_DetailedBuilder : IEntityBuilder<DMSFileMovementRegister_DetailedEntity>
    {
        IList<DMSFileMovementRegister_DetailedEntity> IEntityBuilder<DMSFileMovementRegister_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSFileMovementRegister_DetailedEntity> DMSFileMovementRegister_DetailedEntityList = new List<DMSFileMovementRegister_DetailedEntity>();

            while (reader.Read())
            {
                DMSFileMovementRegister_DetailedEntityList.Add(((IEntityBuilder<DMSFileMovementRegister_DetailedEntity>)this).BuildEntity(reader));
            }

            return (DMSFileMovementRegister_DetailedEntityList.Count > 0) ? DMSFileMovementRegister_DetailedEntityList : null;
        }

        DMSFileMovementRegister_DetailedEntity IEntityBuilder<DMSFileMovementRegister_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FILEMOVEMENTREGISTERID = 0;
            const Int32 FLD_FILETRACKINGID = 1;
            const Int32 FLD_GIVENTOEMPLOYEEID = 2;
            const Int32 FLD_GIVENBYEMPLOYEEID = 3;
            const Int32 FLD_MOVEMENTDATETIME = 4;
            const Int32 FLD_FILEMOVEMENTPLACE = 5;
            const Int32 FLD_FILENAME = 6;
            const Int32 FLD_GIVENBYFULLNAME = 7;
            const Int32 FLD_GIVENTOFULLNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            DMSFileMovementRegister_DetailedEntity dMSFileMovementRegister_DetailedEntity = new DMSFileMovementRegister_DetailedEntity();

            dMSFileMovementRegister_DetailedEntity.FileMovementRegisterID = reader.GetInt64(FLD_FILEMOVEMENTREGISTERID);
            dMSFileMovementRegister_DetailedEntity.FileTrackingID = reader.GetInt64(FLD_FILETRACKINGID);
            dMSFileMovementRegister_DetailedEntity.GivenToEmployeeID = reader.GetInt64(FLD_GIVENTOEMPLOYEEID);
            dMSFileMovementRegister_DetailedEntity.GivenByEmployeeID = reader.GetInt64(FLD_GIVENBYEMPLOYEEID);
            dMSFileMovementRegister_DetailedEntity.MovementDateTime = reader.GetDateTime(FLD_MOVEMENTDATETIME);
            dMSFileMovementRegister_DetailedEntity.FileMovementPlace = reader.GetString(FLD_FILEMOVEMENTPLACE);
            if (reader.IsDBNull(FLD_FILENAME)) { dMSFileMovementRegister_DetailedEntity.FileName = String.Empty; } else { dMSFileMovementRegister_DetailedEntity.FileName = reader.GetString(FLD_FILENAME); }
            if (reader.IsDBNull(FLD_GIVENBYFULLNAME)) { dMSFileMovementRegister_DetailedEntity.GivenByFullName = String.Empty; } else { dMSFileMovementRegister_DetailedEntity.GivenByFullName = reader.GetString(FLD_GIVENBYFULLNAME); }
            if (reader.IsDBNull(FLD_GIVENTOFULLNAME)) { dMSFileMovementRegister_DetailedEntity.GivenToFullName = String.Empty; } else { dMSFileMovementRegister_DetailedEntity.GivenToFullName = reader.GetString(FLD_GIVENTOFULLNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { dMSFileMovementRegister_DetailedEntity.RowNumber = null; } else { dMSFileMovementRegister_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return dMSFileMovementRegister_DetailedEntity;
        }
    }
}
