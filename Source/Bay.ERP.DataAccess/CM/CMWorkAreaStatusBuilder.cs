// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMWorkAreaStatusBuilder : IEntityBuilder<CMWorkAreaStatusEntity>
    {
        IList<CMWorkAreaStatusEntity> IEntityBuilder<CMWorkAreaStatusEntity>.BuildEntities(IDataReader reader)
        {
            List<CMWorkAreaStatusEntity> CMWorkAreaStatusEntityList = new List<CMWorkAreaStatusEntity>();

            while (reader.Read())
            {
                CMWorkAreaStatusEntityList.Add(((IEntityBuilder<CMWorkAreaStatusEntity>)this).BuildEntity(reader));
            }

            return (CMWorkAreaStatusEntityList.Count > 0) ? CMWorkAreaStatusEntityList : null;
        }

        CMWorkAreaStatusEntity IEntityBuilder<CMWorkAreaStatusEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_WORKAREASTATUSID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            CMWorkAreaStatusEntity cMWorkAreaStatusEntity = new CMWorkAreaStatusEntity();

            cMWorkAreaStatusEntity.WorkAreaStatusID = reader.GetInt64(FLD_WORKAREASTATUSID);
            if (reader.IsDBNull(FLD_NAME)) { cMWorkAreaStatusEntity.Name = String.Empty; } else { cMWorkAreaStatusEntity.Name = reader.GetString(FLD_NAME); }
            cMWorkAreaStatusEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMWorkAreaStatusEntity;
        }
    }
}
