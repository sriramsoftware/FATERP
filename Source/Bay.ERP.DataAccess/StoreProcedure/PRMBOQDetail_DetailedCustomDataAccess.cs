// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 04:17:30




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
    internal sealed partial class PRMBOQDetail_DetailedCustomDataAccess : BaseDataAccess, IPRMBOQDetail_DetailedCustomDataAccess
    {
        #region Constructors

        public PRMBOQDetail_DetailedCustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQDetail_DetailedCustomEntity> CreateEntityBuilder<PRMBOQDetail_DetailedCustomEntity>()
        {
            return (new PRMBOQDetail_DetailedCustomBuilder()) as IEntityBuilder<PRMBOQDetail_DetailedCustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMBOQDetail_DetailedCustomEntity> IPRMBOQDetail_DetailedCustomDataAccess.GetIL(String filterExpression)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetail_DetailedCustom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQDetail_DetailedCustomEntity> list = CreateEntityBuilder<PRMBOQDetail_DetailedCustomEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQDetail_DetailedCustomDataAccess.GetDT(String filterExpression)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetail_DetailedCustom";

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
