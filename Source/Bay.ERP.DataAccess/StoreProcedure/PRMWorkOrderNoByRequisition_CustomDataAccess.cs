// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 10:27:04




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
    internal sealed partial class PRMWorkOrderNoByRequisition_CustomDataAccess : BaseDataAccess, IPRMWorkOrderNoByRequisition_CustomDataAccess
    {
        #region Constructors

        public PRMWorkOrderNoByRequisition_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity> CreateEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>()
        {
            return (new PRMWorkOrderNoByRequisition_CustomBuilder()) as IEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMWorkOrderNoByRequisition_CustomEntity> IPRMWorkOrderNoByRequisition_CustomDataAccess.GetIL(Int64 rEQRequisitionID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderNoByRequisition_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@REQRequisitionID", DbType.Int64, rEQRequisitionID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderNoByRequisition_CustomEntity> list = CreateEntityBuilder<PRMWorkOrderNoByRequisition_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderNoByRequisition_CustomDataAccess.GetDT(Int64 rEQRequisitionID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderNoByRequisition_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@REQRequisitionID", DbType.Int64, rEQRequisitionID);	

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
