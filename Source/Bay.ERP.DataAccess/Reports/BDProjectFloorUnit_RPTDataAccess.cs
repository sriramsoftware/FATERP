// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jun-2013, 04:10:14




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
    internal sealed partial class BDProjectFloorUnit_RPTDataAccess : BaseDataAccess, IBDProjectFloorUnit_RPTDataAccess
    {
        #region Constructors

        public BDProjectFloorUnit_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectFloorUnit_RPTEntity> CreateEntityBuilder<BDProjectFloorUnit_RPTEntity>()
        {
            return (new BDProjectFloorUnit_RPTBuilder()) as IEntityBuilder<BDProjectFloorUnit_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProjectFloorUnit_RPTEntity> IBDProjectFloorUnit_RPTDataAccess.GetIL(Int64 ProjectFloorUnitID)
        {
            try
            {
                const string SP = "dbo.BDProjectFloorUnit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, ProjectFloorUnitID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectFloorUnit_RPTEntity> list = CreateEntityBuilder<BDProjectFloorUnit_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProjectFloorUnit_RPTDataAccess.GetDT(Int64 ProjectFloorUnitID)
        {
            try
            {
                const string SP = "dbo.BDProjectFloorUnit_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, ProjectFloorUnitID);	

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
