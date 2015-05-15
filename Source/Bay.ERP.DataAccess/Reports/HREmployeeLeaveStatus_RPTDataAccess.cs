// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2014, 04:20:23




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
    internal sealed partial class HREmployeeLeaveStatus_RPTDataAccess : BaseDataAccess, IHREmployeeLeaveStatus_RPTDataAccess
    {
        #region Constructors

        public HREmployeeLeaveStatus_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeLeaveStatus_RPTEntity> CreateEntityBuilder<HREmployeeLeaveStatus_RPTEntity>()
        {
            return (new HREmployeeLeaveStatus_RPTBuilder()) as IEntityBuilder<HREmployeeLeaveStatus_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeLeaveStatus_RPTEntity> IHREmployeeLeaveStatus_RPTDataAccess.GetIL(Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveStatus_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeLeaveStatus_RPTEntity> list = CreateEntityBuilder<HREmployeeLeaveStatus_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeLeaveStatus_RPTDataAccess.GetDT(Int64 fiscalYearID)
        {
            try
            {
                const string SP = "dbo.HREmployeeLeaveStatus_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, fiscalYearID);	

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
