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
    internal sealed partial class HREmployeeTimeSheet_RPTDataAccess : BaseDataAccess, IHREmployeeTimeSheet_RPTDataAccess
    {
        #region Constructors

        public HREmployeeTimeSheet_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeTimeSheet_RPTEntity> CreateEntityBuilder<HREmployeeTimeSheet_RPTEntity>()
        {
            return (new HREmployeeTimeSheet_RPTBuilder()) as IEntityBuilder<HREmployeeTimeSheet_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<HREmployeeTimeSheet_RPTEntity> IHREmployeeTimeSheet_RPTDataAccess.GetIL(Int64 fromLevel, Int64 toLevel)
        {
            try
            {
                const string SP = "dbo.HREmployeeTimeSheet_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@fromLevel", DbType.Int64, fromLevel);	
				    Database.AddInParameter(cmd, "@toLevel", DbType.Int64, toLevel);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeTimeSheet_RPTEntity> list = CreateEntityBuilder<HREmployeeTimeSheet_RPTEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeTimeSheet_RPTDataAccess.GetDT(Int64 fromLevel, Int64 toLevel)
        {
            try
            {
                const string SP = "dbo.HREmployeeTimeSheet_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@fromLevel", DbType.Int64, fromLevel);	
				    Database.AddInParameter(cmd, "@toLevel", DbType.Int64, toLevel);	

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
