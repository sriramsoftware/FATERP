// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HREmployeeLoanApplication_DetailedBuilder : IEntityBuilder<HREmployeeLoanApplication_DetailedEntity>
    {
        IList<HREmployeeLoanApplication_DetailedEntity> IEntityBuilder<HREmployeeLoanApplication_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HREmployeeLoanApplication_DetailedEntity> HREmployeeLoanApplication_DetailedEntityList = new List<HREmployeeLoanApplication_DetailedEntity>();

            while (reader.Read())
            {
                HREmployeeLoanApplication_DetailedEntityList.Add(((IEntityBuilder<HREmployeeLoanApplication_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HREmployeeLoanApplication_DetailedEntityList.Count > 0) ? HREmployeeLoanApplication_DetailedEntityList : null;
        }

        HREmployeeLoanApplication_DetailedEntity IEntityBuilder<HREmployeeLoanApplication_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_EMPLOYEEFULLNAME = 11;
            const Int32 FLD_LOANCATEGORYNAME = 12;
            const Int32 FLD_CURRENCYNAME = 13;
            const Int32 FLD_EMPLOYEELOANAPPROVALSTATUSNAME = 14;
            const Int32 FLD_ROWNUMBER = 15;

            HREmployeeLoanApplication_DetailedEntity hREmployeeLoanApplication_DetailedEntity = new HREmployeeLoanApplication_DetailedEntity();

            hREmployeeLoanApplication_DetailedEntity.EmployeeLoanApplicationID = reader.GetInt64(FLD_EMPLOYEELOANAPPLICATIONID);
            hREmployeeLoanApplication_DetailedEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            hREmployeeLoanApplication_DetailedEntity.LoanCategoryID = reader.GetInt64(FLD_LOANCATEGORYID);
            hREmployeeLoanApplication_DetailedEntity.AppliedLoanAmount = reader.GetDecimal(FLD_APPLIEDLOANAMOUNT);
            hREmployeeLoanApplication_DetailedEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            if (reader.IsDBNull(FLD_LOANPAYMENTSTARTDATE)) { hREmployeeLoanApplication_DetailedEntity.LoanPaymentStartDate = null; } else { hREmployeeLoanApplication_DetailedEntity.LoanPaymentStartDate = reader.GetDateTime(FLD_LOANPAYMENTSTARTDATE); }
            if (reader.IsDBNull(FLD_LOANPAYMENTENDDATE)) { hREmployeeLoanApplication_DetailedEntity.LoanPaymentEndDate = null; } else { hREmployeeLoanApplication_DetailedEntity.LoanPaymentEndDate = reader.GetDateTime(FLD_LOANPAYMENTENDDATE); }
            if (reader.IsDBNull(FLD_NUMBEROFINSTALLMENT)) { hREmployeeLoanApplication_DetailedEntity.NumberOfInstallment = null; } else { hREmployeeLoanApplication_DetailedEntity.NumberOfInstallment = reader.GetDecimal(FLD_NUMBEROFINSTALLMENT); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { hREmployeeLoanApplication_DetailedEntity.Description = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            hREmployeeLoanApplication_DetailedEntity.EmployeeLoanApprovalStatusID = reader.GetInt64(FLD_EMPLOYEELOANAPPROVALSTATUSID);
            if (reader.IsDBNull(FLD_REMARKS)) { hREmployeeLoanApplication_DetailedEntity.Remarks = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_EMPLOYEEFULLNAME)) { hREmployeeLoanApplication_DetailedEntity.EmployeeFullName = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.EmployeeFullName = reader.GetString(FLD_EMPLOYEEFULLNAME); }
            if (reader.IsDBNull(FLD_LOANCATEGORYNAME)) { hREmployeeLoanApplication_DetailedEntity.LoanCategoryName = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.LoanCategoryName = reader.GetString(FLD_LOANCATEGORYNAME); }
            if (reader.IsDBNull(FLD_CURRENCYNAME)) { hREmployeeLoanApplication_DetailedEntity.CurrencyName = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.CurrencyName = reader.GetString(FLD_CURRENCYNAME); }
            if (reader.IsDBNull(FLD_EMPLOYEELOANAPPROVALSTATUSNAME)) { hREmployeeLoanApplication_DetailedEntity.EmployeeLoanApprovalStatusName = String.Empty; } else { hREmployeeLoanApplication_DetailedEntity.EmployeeLoanApprovalStatusName = reader.GetString(FLD_EMPLOYEELOANAPPROVALSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hREmployeeLoanApplication_DetailedEntity.RowNumber = null; } else { hREmployeeLoanApplication_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hREmployeeLoanApplication_DetailedEntity;
        }
    }
}
