// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Feb-2013, 06:05:18




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
    internal sealed partial class PRMMaterialRequisitionItem_CustomDataAccess : BaseDataAccess, IPRMMaterialRequisitionItem_CustomDataAccess
    {
        #region Constructors

        public PRMMaterialRequisitionItem_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity> CreateEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>()
        {
            return (new PRMMaterialRequisitionItem_CustomBuilder()) as IEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMMaterialRequisitionItem_CustomEntity> IPRMMaterialRequisitionItem_CustomDataAccess.GetIL(String filterExpression)
        {
            try
            {
                const string SP = "dbo.PRMMaterialRequisitionItem_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMMaterialRequisitionItem_CustomEntity> list = CreateEntityBuilder<PRMMaterialRequisitionItem_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMMaterialRequisitionItem_CustomDataAccess.GetDT(String filterExpression)
        {
            try
            {
                const string SP = "dbo.PRMMaterialRequisitionItem_Custom";

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
