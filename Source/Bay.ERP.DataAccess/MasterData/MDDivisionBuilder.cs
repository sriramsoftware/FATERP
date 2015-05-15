// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDivisionBuilder : IEntityBuilder<MDDivisionEntity>
    {
        IList<MDDivisionEntity> IEntityBuilder<MDDivisionEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDivisionEntity> MDDivisionEntityList = new List<MDDivisionEntity>();

            while (reader.Read())
            {
                MDDivisionEntityList.Add(((IEntityBuilder<MDDivisionEntity>)this).BuildEntity(reader));
            }

            return (MDDivisionEntityList.Count > 0) ? MDDivisionEntityList : null;
        }

        MDDivisionEntity IEntityBuilder<MDDivisionEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DIVISIONID = 0;
            const Int32 FLD_DIVISIONNAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDDivisionEntity mDDivisionEntity = new MDDivisionEntity();

            mDDivisionEntity.DivisionID = reader.GetInt64(FLD_DIVISIONID);
            mDDivisionEntity.DivisionName = reader.GetString(FLD_DIVISIONNAME);
            mDDivisionEntity.Remarks = reader.GetString(FLD_REMARKS);
            mDDivisionEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDivisionEntity;
        }
    }
}
