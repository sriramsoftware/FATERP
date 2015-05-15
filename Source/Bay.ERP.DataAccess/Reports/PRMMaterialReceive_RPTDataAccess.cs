// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jul-2012, 11:22:51




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
    internal sealed partial class PRMMaterialReceive_RPTDataAccess : BaseDataAccess, IPRMMaterialReceive_RPTDataAccess
    {
        #region Constructors

        public PRMMaterialReceive_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMMaterialReceive_RPTEntity> CreateEntityBuilder<PRMMaterialReceive_RPTEntity>()
        {
            return (new PRMMaterialReceive_RPTBuilder()) as IEntityBuilder<PRMMaterialReceive_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMMaterialReceive_RPTEntity> IPRMMaterialReceive_RPTDataAccess.GetIL(Int64 materialReceiveID)
        {
            try
            {
                const string SP = "dbo.PRMMaterialReceive_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, materialReceiveID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMMaterialReceive_RPTEntity> list = CreateEntityBuilder<PRMMaterialReceive_RPTEntity>().BuildEntities(reader);

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

        DataTable IPRMMaterialReceive_RPTDataAccess.GetDT(Int64 materialReceiveID)
        {
            try
            {
                const string SP = "dbo.PRMMaterialReceive_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, materialReceiveID);	

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