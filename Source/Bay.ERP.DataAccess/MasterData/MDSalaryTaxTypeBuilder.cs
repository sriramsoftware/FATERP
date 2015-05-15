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
    internal sealed class MDSalaryTaxTypeBuilder : IEntityBuilder<MDSalaryTaxTypeEntity>
    {
        IList<MDSalaryTaxTypeEntity> IEntityBuilder<MDSalaryTaxTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDSalaryTaxTypeEntity> MDSalaryTaxTypeEntityList = new List<MDSalaryTaxTypeEntity>();

            while (reader.Read())
            {
                MDSalaryTaxTypeEntityList.Add(((IEntityBuilder<MDSalaryTaxTypeEntity>)this).BuildEntity(reader));
            }

            return (MDSalaryTaxTypeEntityList.Count > 0) ? MDSalaryTaxTypeEntityList : null;
        }

        MDSalaryTaxTypeEntity IEntityBuilder<MDSalaryTaxTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SALARYTAXTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            MDSalaryTaxTypeEntity mDSalaryTaxTypeEntity = new MDSalaryTaxTypeEntity();

            mDSalaryTaxTypeEntity.SalaryTaxTypeID = reader.GetInt64(FLD_SALARYTAXTYPEID);
            mDSalaryTaxTypeEntity.Name = reader.GetString(FLD_NAME);
            mDSalaryTaxTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDSalaryTaxTypeEntity;
        }
    }
}
