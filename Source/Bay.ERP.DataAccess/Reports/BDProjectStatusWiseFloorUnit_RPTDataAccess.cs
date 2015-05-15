// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




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
    internal sealed partial class BDProjectStatusWiseFloorUnit_RPTDataAccess : BaseDataAccess, IBDProjectStatusWiseFloorUnit_RPTDataAccess
    {
        #region Constructors

        public BDProjectStatusWiseFloorUnit_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity> CreateEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>()
        {
            return (new BDProjectStatusWiseFloorUnit_RPTBuilder()) as IEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProjectStatusWiseFloorUnit_RPTEntity> IBDProjectStatusWiseFloorUnit_RPTDataAccess.GetIL(Int64 projectFloorUnitStatusID)
        {
            try
            {
                const string SP = "dbo.BDProjectStatusWiseFloorUnit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, projectFloorUnitStatusID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectStatusWiseFloorUnit_RPTEntity> list = CreateEntityBuilder<BDProjectStatusWiseFloorUnit_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProjectStatusWiseFloorUnit_RPTDataAccess.GetDT(Int64 projectFloorUnitStatusID)
        {
            try
            {
                const string SP = "dbo.BDProjectStatusWiseFloorUnit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectFloorUnitStatusID", DbType.Int64, projectFloorUnitStatusID);	

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
