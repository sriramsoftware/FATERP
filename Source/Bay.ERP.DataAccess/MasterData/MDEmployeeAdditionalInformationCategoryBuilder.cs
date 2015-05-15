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
    internal sealed class MDEmployeeAdditionalInformationCategoryBuilder : IEntityBuilder<MDEmployeeAdditionalInformationCategoryEntity>
    {
        IList<MDEmployeeAdditionalInformationCategoryEntity> IEntityBuilder<MDEmployeeAdditionalInformationCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDEmployeeAdditionalInformationCategoryEntity> MDEmployeeAdditionalInformationCategoryEntityList = new List<MDEmployeeAdditionalInformationCategoryEntity>();

            while (reader.Read())
            {
                MDEmployeeAdditionalInformationCategoryEntityList.Add(((IEntityBuilder<MDEmployeeAdditionalInformationCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDEmployeeAdditionalInformationCategoryEntityList.Count > 0) ? MDEmployeeAdditionalInformationCategoryEntityList : null;
        }

        MDEmployeeAdditionalInformationCategoryEntity IEntityBuilder<MDEmployeeAdditionalInformationCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEADDITIONALINFORMATIONCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDEmployeeAdditionalInformationCategoryEntity mDEmployeeAdditionalInformationCategoryEntity = new MDEmployeeAdditionalInformationCategoryEntity();

            mDEmployeeAdditionalInformationCategoryEntity.EmployeeAdditionalInformationCategoryID = reader.GetInt64(FLD_EMPLOYEEADDITIONALINFORMATIONCATEGORYID);
            mDEmployeeAdditionalInformationCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDEmployeeAdditionalInformationCategoryEntity.Description = String.Empty; } else { mDEmployeeAdditionalInformationCategoryEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDEmployeeAdditionalInformationCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDEmployeeAdditionalInformationCategoryEntity;
        }
    }
}
