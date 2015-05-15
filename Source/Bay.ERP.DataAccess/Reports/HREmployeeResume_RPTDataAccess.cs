// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:16:34




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
    internal sealed partial class HREmployeeResume_RPTDataAccess : BaseDataAccess, IHREmployeeResume_RPTDataAccess
    {
        #region Constructors

        public HREmployeeResume_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeResume_RPTEntity> CreateEntityBuilder<HREmployeeResume_RPTEntity>()
        {
            return (new HREmployeeResume_RPTBuilder()) as IEntityBuilder<HREmployeeResume_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeResume_RPTEntity> IHREmployeeResume_RPTDataAccess.GetIL(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.HREmployeeResume_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);		

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeResume_RPTEntity> list = CreateEntityBuilder<HREmployeeResume_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeResume_RPTDataAccess.GetDT(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.HREmployeeResume_RPT";

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
