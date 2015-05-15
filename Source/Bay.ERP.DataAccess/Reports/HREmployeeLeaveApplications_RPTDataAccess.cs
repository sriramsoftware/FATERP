// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




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
    internal sealed partial class HREmployeeLeaveApplications_RPTDataAccess : BaseDataAccess, IHREmployeeLeaveApplications_RPTDataAccess
    {
        #region Constructors

        public HREmployeeLeaveApplications_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeLeaveApplications_RPTEntity> CreateEntityBuilder<HREmployeeLeaveApplications_RPTEntity>()
        {
            return (new HREmployeeLeaveApplications_RPTBuilder()) as IEntityBuilder<HREmployeeLeaveApplications_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeLeaveApplications_RPTEntity> IHREmployeeLeaveApplications_RPTDataAccess.GetIL(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveApplications_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, salarySessionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeLeaveApplications_RPTEntity> list = CreateEntityBuilder<HREmployeeLeaveApplications_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeLeaveApplications_RPTDataAccess.GetDT(Int64 salarySessionID)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveApplications_RPT";

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
