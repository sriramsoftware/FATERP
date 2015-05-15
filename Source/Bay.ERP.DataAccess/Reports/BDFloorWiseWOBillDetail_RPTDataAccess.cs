// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 01:19:26




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
    internal sealed partial class BDFloorWiseWOBillDetail_RPTDataAccess : BaseDataAccess, IBDFloorWiseWOBillDetail_RPTDataAccess
    {
        #region Constructors

        public BDFloorWiseWOBillDetail_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity> CreateEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>()
        {
            return (new BDFloorWiseWOBillDetail_RPTBuilder()) as IEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDFloorWiseWOBillDetail_RPTEntity> IBDFloorWiseWOBillDetail_RPTDataAccess.GetIL(String filterExpression)
        {
            try
            {
                const string SP = "dbo.BDFloorWiseWOBillDetail_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDFloorWiseWOBillDetail_RPTEntity> list = CreateEntityBuilder<BDFloorWiseWOBillDetail_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDFloorWiseWOBillDetail_RPTDataAccess.GetDT(String filterExpression)
        {
            try
            {
                const string SP = "dbo.BDFloorWiseWOBillDetail_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

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
