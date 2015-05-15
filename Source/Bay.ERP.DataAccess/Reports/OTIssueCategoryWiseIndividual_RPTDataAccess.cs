// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Sep-2013, 04:16:48




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
    internal sealed partial class OTIssueCategoryWiseIndividual_RPTDataAccess : BaseDataAccess, IOTIssueCategoryWiseIndividual_RPTDataAccess
    {
        #region Constructors

        public OTIssueCategoryWiseIndividual_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity> CreateEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>()
        {
            return (new OTIssueCategoryWiseIndividual_RPTBuilder()) as IEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<OTIssueCategoryWiseIndividual_RPTEntity> IOTIssueCategoryWiseIndividual_RPTDataAccess.GetIL(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID)
        {
            try
            {
                const string SP = "dbo.OTIssueCategoryWiseIndividual_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@AssingedEmployeeID", DbType.Int64, assingedEmployeeID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssueCategoryWiseIndividual_RPTEntity> list = CreateEntityBuilder<OTIssueCategoryWiseIndividual_RPTEntity>().BuildEntities(reader);

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

        DataTable IOTIssueCategoryWiseIndividual_RPTDataAccess.GetDT(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID)
        {
            try
            {
                const string SP = "dbo.OTIssueCategoryWiseIndividual_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FromDate", DbType.DateTime, fromDate);	
				    Database.AddInParameter(cmd, "@ToDate", DbType.DateTime, toDate);	
				    Database.AddInParameter(cmd, "@AssingedEmployeeID", DbType.Int64, assingedEmployeeID);	

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
