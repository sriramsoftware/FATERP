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
    internal sealed class MDEmployeeLanguageBuilder : IEntityBuilder<MDEmployeeLanguageEntity>
    {
        IList<MDEmployeeLanguageEntity> IEntityBuilder<MDEmployeeLanguageEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeLanguageEntity> MDEmployeeLanguageEntityList = new List<MDEmployeeLanguageEntity>();

            while (reader.Read())
            {
                MDEmployeeLanguageEntityList.Add(((IEntityBuilder<MDEmployeeLanguageEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeLanguageEntityList.Count > 0) ? MDEmployeeLanguageEntityList : null;
        }

        MDEmployeeLanguageEntity IEntityBuilder<MDEmployeeLanguageEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELANGUAGEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDEmployeeLanguageEntity mDEmployeeLanguageEntity = new MDEmployeeLanguageEntity();

            mDEmployeeLanguageEntity.EmployeeLanguageID = reader.GetInt64(FLD_EMPLOYEELANGUAGEID);
            mDEmployeeLanguageEntity.Name = reader.GetString(FLD_NAME);
            mDEmployeeLanguageEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeLanguageEntity;
        }
    }
}
