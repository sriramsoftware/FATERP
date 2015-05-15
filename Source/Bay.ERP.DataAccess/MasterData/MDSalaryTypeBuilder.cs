// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDSalaryTypeBuilder : IEntityBuilder<MDSalaryTypeEntity>
    {
        IList<MDSalaryTypeEntity> IEntityBuilder<MDSalaryTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalaryTypeEntity> MDSalaryTypeEntityList = new List<MDSalaryTypeEntity>();

            while (reader.Read())
            {
                MDSalaryTypeEntityList.Add(((IEntityBuilder<MDSalaryTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSalaryTypeEntityList.Count > 0) ? MDSalaryTypeEntityList : null;
        }

        MDSalaryTypeEntity IEntityBuilder<MDSalaryTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDSalaryTypeEntity mDSalaryTypeEntity = new MDSalaryTypeEntity();

            mDSalaryTypeEntity.SalaryTypeID = reader.GetInt64(FLD_SALARYTYPEID);
            mDSalaryTypeEntity.Name = reader.GetString(FLD_NAME);
            mDSalaryTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSalaryTypeEntity;
        }
    }
}
