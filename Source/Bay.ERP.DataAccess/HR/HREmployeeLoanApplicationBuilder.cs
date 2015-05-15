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
    internal sealed class HREmployeeLoanApplicationBuilder : IEntityBuilder<HREmployeeLoanApplicationEntity>
    {
        IList<HREmployeeLoanApplicationEntity> IEntityBuilder<HREmployeeLoanApplicationEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLoanApplicationEntity> HREmployeeLoanApplicationEntityList = new List<HREmployeeLoanApplicationEntity>();

            while (reader.Read())
            {
                HREmployeeLoanApplicationEntityList.Add(((IEntityBuilder<HREmployeeLoanApplicationEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLoanApplicationEntityList.Count > 0) ? HREmployeeLoanApplicationEntityList : null;
        }

        HREmployeeLoanApplicationEntity IEntityBuilder<HREmployeeLoanApplicationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_EMPLOYEELOANAPPLICATIONID = 0;
            const Int32 FLD_EMPLOYEEID = 1;
            const Int32 FLD_LOANCATEGORYID = 2;
            const Int32 FLD_APPLIEDLOANAMOUNT = 3;
            const Int32 FLD_CURRENCYID = 4;
            const Int32 FLD_LOANPAYMENTSTARTDATE = 5;
            const Int32 FLD_LOANPAYMENTENDDATE = 6;
            const Int32 FLD_NUMBEROFINSTALLMENT = 7;
            const Int32 FLD_DESCRIPTION = 8;
            const Int32 FLD_EMPLOYEELOANAPPROVALSTATUSID = 9;
            const Int32 FLD_REMARKS = 10;

            HREmployeeLoanApplicationEntity hREmployeeLoanApplicationEntity = new HREmployeeLoanApplicationEntity();

            hREmployeeLoanApplicationEntity.EmployeeLoanApplicationID = reader.GetInt64(FLD_EMPLOYEELOANAPPLICATIONID);
            hREmployeeLoanApplicationEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLoanApplicationEntity.LoanCategoryID = reader.GetInt64(FLD_LOANCATEGORYID);
            hREmployeeLoanApplicationEntity.AppliedLoanAmount = reader.GetDecimal(FLD_APPLIEDLOANAMOUNT);
            hREmployeeLoanApplicationEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            if (reader.IsDBNull(FLD_LOANPAYMENTSTARTDATE)) { hREmployeeLoanApplicationEntity.LoanPaymentStartDate = null; } else { hREmployeeLoanApplicationEntity.LoanPaymentStartDate = reader.GetDateTime(FLD_LOANPAYMENTSTARTDATE); }
            if (reader.IsDBNull(FLD_LOANPAYMENTENDDATE)) { hREmployeeLoanApplicationEntity.LoanPaymentEndDate = null; } else { hREmployeeLoanApplicationEntity.LoanPaymentEndDate = reader.GetDateTime(FLD_LOANPAYMENTENDDATE); }
            if (reader.IsDBNull(FLD_NUMBEROFINSTALLMENT)) { hREmployeeLoanApplicationEntity.NumberOfInstallment = null; } else { hREmployeeLoanApplicationEntity.NumberOfInstallment = reader.GetDecimal(FLD_NUMBEROFINSTALLMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeLoanApplicationEntity.Description = String.Empty; } else { hREmployeeLoanApplicationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hREmployeeLoanApplicationEntity.EmployeeLoanApprovalStatusID = reader.GetInt64(FLD_EMPLOYEELOANAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeLoanApplicationEntity.Remarks = String.Empty; } else { hREmployeeLoanApplicationEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return hREmployeeLoanApplicationEntity;
        }
    }
}
