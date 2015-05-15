// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




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
    internal sealed partial class PRMWorkOrderSingleClickFromRequisition_CustomDataAccess : BaseDataAccess, IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess
    {
        #region Constructors

        public PRMWorkOrderSingleClickFromRequisition_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity> CreateEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>()
        {
            return (new PRMWorkOrderSingleClickFromRequisition_CustomBuilder()) as IEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess.GetIL(Int64 requisitionID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderSingleClickFromRequisition_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	
				    Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, preparedByMemberID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> list = CreateEntityBuilder<PRMWorkOrderSingleClickFromRequisition_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess.GetDT(Int64 requisitionID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.PRMWorkOrderSingleClickFromRequisition_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@RequisitionID", DbType.Int64, requisitionID);	
				    Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, preparedByMemberID);	

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
