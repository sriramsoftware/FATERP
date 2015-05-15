// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Aug-2013, 10:45:50




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
    internal sealed partial class OTIssueCategoryWise_RPTDataAccess : BaseDataAccess, IOTIssueCategoryWise_RPTDataAccess
    {
        #region Constructors

        public OTIssueCategoryWise_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssueCategoryWise_RPTEntity> CreateEntityBuilder<OTIssueCategoryWise_RPTEntity>()
        {
            return (new OTIssueCategoryWise_RPTBuilder()) as IEntityBuilder<OTIssueCategoryWise_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<OTIssueCategoryWise_RPTEntity> IOTIssueCategoryWise_RPTDataAccess.GetIL(DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.OTIssueCategoryWise_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssueCategoryWise_RPTEntity> list = CreateEntityBuilder<OTIssueCategoryWise_RPTEntity>().BuildEntities(reader);

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

        DataTable IOTIssueCategoryWise_RPTDataAccess.GetDT(DateTime fromDate, DateTime toDate)
        {
            try
            {
                const string SP = "dbo.OTIssueCategoryWise_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	

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
