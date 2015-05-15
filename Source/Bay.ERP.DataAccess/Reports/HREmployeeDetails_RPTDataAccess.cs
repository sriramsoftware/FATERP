// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2014, 04:10:32




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
    internal sealed partial class HREmployeeDetails_RPTDataAccess : BaseDataAccess, IHREmployeeDetails_RPTDataAccess
    {
        #region Constructors

        public HREmployeeDetails_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeDetails_RPTEntity> CreateEntityBuilder<HREmployeeDetails_RPTEntity>()
        {
            return (new HREmployeeDetails_RPTBuilder()) as IEntityBuilder<HREmployeeDetails_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeDetails_RPTEntity> IHREmployeeDetails_RPTDataAccess.GetIL(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.HREmployeeDetails_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeDetails_RPTEntity> list = CreateEntityBuilder<HREmployeeDetails_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeDetails_RPTDataAccess.GetDT(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.HREmployeeDetails_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	

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
