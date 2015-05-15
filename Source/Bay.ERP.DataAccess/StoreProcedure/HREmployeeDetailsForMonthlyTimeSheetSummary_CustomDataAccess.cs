// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jan-2014, 04:42:27




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class HREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess : BaseDataAccess, IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess
    {
        #region Constructors

        public HREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> CreateEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>()
        {
            return (new HREmployeeDetailsForMonthlyTimeSheetSummary_CustomBuilder()) as IEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess.GetIL(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeDetailsForMonthlyTimeSheetSummary_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> list = CreateEntityBuilder<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomDataAccess.GetDT(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeDetailsForMonthlyTimeSheetSummary_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);	

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
