// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




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
    internal sealed partial class HREmployeeMonthlyTimeSheetSummary_RPTDataAccess : BaseDataAccess, IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess
    {
        #region Constructors

        public HREmployeeMonthlyTimeSheetSummary_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity> CreateEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>()
        {
            return (new HREmployeeMonthlyTimeSheetSummary_RPTBuilder()) as IEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeMonthlyTimeSheetSummary_RPTEntity> IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess.GetIL(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);
                    Database.AddInParameter(cmd, "@From", DbType.Int64, from);
                    Database.AddInParameter(cmd, "@To", DbType.Int64, to);
                    Database.AddInParameter(cmd, "@Other", DbType.Int64, other);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeMonthlyTimeSheetSummary_RPTEntity> list = CreateEntityBuilder<HREmployeeMonthlyTimeSheetSummary_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeMonthlyTimeSheetSummary_RPTDataAccess.GetDT(Int64 salarySessionID, Int64 from, Int64 to, Int64 other)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);
                    Database.AddInParameter(cmd, "@From", DbType.Int64, from);
                    Database.AddInParameter(cmd, "@To", DbType.Int64, to);
                    Database.AddInParameter(cmd, "@Other", DbType.Int64, other);

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
