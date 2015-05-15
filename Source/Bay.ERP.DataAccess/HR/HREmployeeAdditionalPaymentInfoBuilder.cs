// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeAdditionalPaymentInfoBuilder : IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>
    {
        IList<HREmployeeAdditionalPaymentInfoEntity> IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeAdditionalPaymentInfoEntity> HREmployeeAdditionalPaymentInfoEntityList = new List<HREmployeeAdditionalPaymentInfoEntity>();

            while (reader.Read())
            {
                HREmployeeAdditionalPaymentInfoEntityList.Add(((IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeAdditionalPaymentInfoEntityList.Count > 0) ? HREmployeeAdditionalPaymentInfoEntityList : null;
        }

        HREmployeeAdditionalPaymentInfoEntity IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEEADDITONALPAYMENTINFOID = 0;
            const Int32 FLD_PAYDATE = 1;
            const Int32 FLD_PAYAMOUNT = 2;
            const Int32 FLD_PAYCURRENCY = 3;
            const Int32 FLD_NOTES = 4;
            const Int32 FLD_PAYNOW = 5;
            const Int32 FLD_PAYDURINGPAYROLLGENERATIONEDITORID = 6;

            HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity = new HREmployeeAdditionalPaymentInfoEntity();

            hREmployeeAdditionalPaymentInfoEntity.EmployeeAdditonalPaymentInfoID = reader.GetInt64(FLD_EMPLOYEEADDITONALPAYMENTINFOID);
            hREmployeeAdditionalPaymentInfoEntity.PayDate = reader.GetDateTime(FLD_PAYDATE);
            hREmployeeAdditionalPaymentInfoEntity.PayAmount = reader.GetDecimal(FLD_PAYAMOUNT);
            hREmployeeAdditionalPaymentInfoEntity.PayCurrency = reader.GetDecimal(FLD_PAYCURRENCY);
            hREmployeeAdditionalPaymentInfoEntity.Notes = reader.GetString(FLD_NOTES);
            hREmployeeAdditionalPaymentInfoEntity.PayNow = reader.GetBoolean(FLD_PAYNOW);
            hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID = reader.GetInt64(FLD_PAYDURINGPAYROLLGENERATIONEDITORID);

            return hREmployeeAdditionalPaymentInfoEntity;
        }
    }
}
