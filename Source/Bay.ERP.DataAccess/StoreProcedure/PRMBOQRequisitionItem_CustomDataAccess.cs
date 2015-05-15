// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




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
    internal sealed partial class PRMBOQRequisitionItem_CustomDataAccess : BaseDataAccess, IPRMBOQRequisitionItem_CustomDataAccess
    {
        #region Constructors

        public PRMBOQRequisitionItem_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQRequisitionItem_CustomEntity> CreateEntityBuilder<PRMBOQRequisitionItem_CustomEntity>()
        {
            return (new PRMBOQRequisitionItem_CustomBuilder()) as IEntityBuilder<PRMBOQRequisitionItem_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMBOQRequisitionItem_CustomEntity> IPRMBOQRequisitionItem_CustomDataAccess.GetIL(Int64 projectID, Int64 itemCategoryID)
        {
            try
            {
                const string SP = "dbo.PRMBOQRequisitionItem_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
				    Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, itemCategoryID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQRequisitionItem_CustomEntity> list = CreateEntityBuilder<PRMBOQRequisitionItem_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQRequisitionItem_CustomDataAccess.GetDT(Int64 projectID, Int64 itemCategoryID)
        {
            try
            {
                const string SP = "dbo.PRMBOQRequisitionItem_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
				    Database.AddInParameter(cmd, "@ItemCategoryID", DbType.Int64, itemCategoryID);	

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
