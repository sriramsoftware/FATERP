// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 12:10:49




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
    internal sealed partial class CMBillWithRequisitionItemMap_RPTDataAccess : BaseDataAccess, ICMBillWithRequisitionItemMap_RPTDataAccess
    {
        #region Constructors

        public CMBillWithRequisitionItemMap_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity> CreateEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>()
        {
            return (new CMBillWithRequisitionItemMap_RPTBuilder()) as IEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<CMBillWithRequisitionItemMap_RPTEntity> ICMBillWithRequisitionItemMap_RPTDataAccess.GetIL(Int64 billID)
        {
            try
            {
                const string SP = "dbo.CMBillWithRequisitionItemMap_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BillID", DbType.Int64, billID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillWithRequisitionItemMap_RPTEntity> list = CreateEntityBuilder<CMBillWithRequisitionItemMap_RPTEntity>().BuildEntities(reader);

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

        DataTable ICMBillWithRequisitionItemMap_RPTDataAccess.GetDT(Int64 billID)
        {
            try
            {
                const string SP = "dbo.CMBillWithRequisitionItemMap_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BillID", DbType.Int64, billID);	

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
