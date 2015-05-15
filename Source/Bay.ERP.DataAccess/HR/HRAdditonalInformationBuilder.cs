// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRAdditonalInformationBuilder : IEntityBuilder<HRAdditonalInformationEntity>
    {
        IList<HRAdditonalInformationEntity> IEntityBuilder<HRAdditonalInformationEntity>.BuildEntities(IDataReader reader)
        {
            List<HRAdditonalInformationEntity> HRAdditonalInformationEntityList = new List<HRAdditonalInformationEntity>();

            while (reader.Read())
            {
                HRAdditonalInformationEntityList.Add(((IEntityBuilder<HRAdditonalInformationEntity>)this).BuildEntity(reader));
            }

            return (HRAdditonalInformationEntityList.Count > 0) ? HRAdditonalInformationEntityList : null;
        }

        HRAdditonalInformationEntity IEntityBuilder<HRAdditonalInformationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ADDITONALINFORMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_EMPLOYEEADDITIONALINFORMATIONCATEGORYID = 2;
            const Int32 FLD_VALUE = 3;
            const Int32 FLD_EXTRASTRINGCOLUMN = 4;
            const Int32 FLD_EXTRAFIELD1 = 5;
            const Int32 FLD_REMARKS = 6;

            HRAdditonalInformationEntity hRAdditonalInformationEntity = new HRAdditonalInformationEntity();

            hRAdditonalInformationEntity.AdditonalInformationID = reader.GetInt64(FLD_ADDITONALINFORMATIONID);
            hRAdditonalInformationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hRAdditonalInformationEntity.EmployeeAdditionalInformationCategoryID = reader.GetInt64(FLD_EMPLOYEEADDITIONALINFORMATIONCATEGORYID);
            hRAdditonalInformationEntity.Value = reader.GetDecimal(FLD_VALUE);
            if (reader.IsDBNull(FLD_EXTRASTRINGCOLUMN)) { hRAdditonalInformationEntity.ExtraStringColumn = String.Empty; } else { hRAdditonalInformationEntity.ExtraStringColumn = reader.GetString(FLD_EXTRASTRINGCOLUMN); }
            if (reader.IsDBNull(FLD_EXTRAFIELD1)) { hRAdditonalInformationEntity.ExtraField1 = String.Empty; } else { hRAdditonalInformationEntity.ExtraField1 = reader.GetString(FLD_EXTRAFIELD1); }
            if (reader.IsDBNull(FLD_REMARKS)) { hRAdditonalInformationEntity.Remarks = String.Empty; } else { hRAdditonalInformationEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hRAdditonalInformationEntity;
        }
    }
}
