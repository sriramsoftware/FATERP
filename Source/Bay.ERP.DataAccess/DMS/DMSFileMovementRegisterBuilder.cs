// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2012, 10:20:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class DMSFileMovementRegisterBuilder : IEntityBuilder<DMSFileMovementRegisterEntity>
    {
        IList<DMSFileMovementRegisterEntity> IEntityBuilder<DMSFileMovementRegisterEntity>.BuildEntities(IDataReader reader)
        {
            List<DMSFileMovementRegisterEntity> DMSFileMovementRegisterEntityList = new List<DMSFileMovementRegisterEntity>();

            while (reader.Read())
            {
                DMSFileMovementRegisterEntityList.Add(((IEntityBuilder<DMSFileMovementRegisterEntity>)this).BuildEntity(reader));
            }

            return (DMSFileMovementRegisterEntityList.Count > 0) ? DMSFileMovementRegisterEntityList : null;
        }

        DMSFileMovementRegisterEntity IEntityBuilder<DMSFileMovementRegisterEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FILEMOVEMENTREGISTERID = 0;
            const Int32 FLD_FILETRACKINGID = 1;
            const Int32 FLD_GIVENTOEMPLOYEEID = 2;
            const Int32 FLD_GIVENBYEMPLOYEEID = 3;
            const Int32 FLD_MOVEMENTDATETIME = 4;
            const Int32 FLD_FILEMOVEMENTPLACE = 5;

            DMSFileMovementRegisterEntity dMSFileMovementRegisterEntity = new DMSFileMovementRegisterEntity();

            dMSFileMovementRegisterEntity.FileMovementRegisterID = reader.GetInt64(FLD_FILEMOVEMENTREGISTERID);
            dMSFileMovementRegisterEntity.FileTrackingID = reader.GetInt64(FLD_FILETRACKINGID);
            dMSFileMovementRegisterEntity.GivenToEmployeeID = reader.GetInt64(FLD_GIVENTOEMPLOYEEID);
            dMSFileMovementRegisterEntity.GivenByEmployeeID = reader.GetInt64(FLD_GIVENBYEMPLOYEEID);
            dMSFileMovementRegisterEntity.MovementDateTime = reader.GetDateTime(FLD_MOVEMENTDATETIME);
            dMSFileMovementRegisterEntity.FileMovementPlace = reader.GetString(FLD_FILEMOVEMENTPLACE);

            return dMSFileMovementRegisterEntity;
        }
    }
}
