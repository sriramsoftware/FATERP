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
    internal sealed class HREmployeeVisaInfomationBuilder : IEntityBuilder<HREmployeeVisaInfomationEntity>
    {
        IList<HREmployeeVisaInfomationEntity> IEntityBuilder<HREmployeeVisaInfomationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeVisaInfomationEntity> HREmployeeVisaInfomationEntityList = new List<HREmployeeVisaInfomationEntity>();

            while (reader.Read())
            {
                HREmployeeVisaInfomationEntityList.Add(((IEntityBuilder<HREmployeeVisaInfomationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeVisaInfomationEntityList.Count > 0) ? HREmployeeVisaInfomationEntityList : null;
        }

        HREmployeeVisaInfomationEntity IEntityBuilder<HREmployeeVisaInfomationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEVISAINFOMATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_VISASTATUSID = 2;
            const Int32 FLD_VISATRANSFERINFO = 3;
            const Int32 FLD_PROFESSIONINVISA = 4;
            const Int32 FLD_VISANUMBER = 5;
            const Int32 FLD_VISAISSUEDDATE = 6;
            const Int32 FLD_REMARKS = 7;

            HREmployeeVisaInfomationEntity hREmployeeVisaInfomationEntity = new HREmployeeVisaInfomationEntity();

            hREmployeeVisaInfomationEntity.EmployeeVisaInfomationID = reader.GetInt64(FLD_EMPLOYEEVISAINFOMATIONID);
            hREmployeeVisaInfomationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeVisaInfomationEntity.VisaStatusID = reader.GetInt64(FLD_VISASTATUSID);
            if (reader.IsDBNull(FLD_VISATRANSFERINFO)) { hREmployeeVisaInfomationEntity.VisaTransferInfo = String.Empty; } else { hREmployeeVisaInfomationEntity.VisaTransferInfo = reader.GetString(FLD_VISATRANSFERINFO); }
            hREmployeeVisaInfomationEntity.ProfessionInVisa = reader.GetString(FLD_PROFESSIONINVISA);
            hREmployeeVisaInfomationEntity.VisaNumber = reader.GetString(FLD_VISANUMBER);
            if (reader.IsDBNull(FLD_VISAISSUEDDATE)) { hREmployeeVisaInfomationEntity.VisaIssuedDate = null; } else { hREmployeeVisaInfomationEntity.VisaIssuedDate = reader.GetDateTime(FLD_VISAISSUEDDATE); }
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeVisaInfomationEntity.Remarks = String.Empty; } else { hREmployeeVisaInfomationEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeVisaInfomationEntity;
        }
    }
}
