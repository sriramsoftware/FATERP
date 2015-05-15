// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jan-2013, 11:24:12




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
    internal sealed partial class APApprovedRequisitionForWOByPanelMember_CustomDataAccess : BaseDataAccess, IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess
    {
        #region Constructors

        public APApprovedRequisitionForWOByPanelMember_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity> CreateEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>()
        {
            return (new APApprovedRequisitionForWOByPanelMember_CustomBuilder()) as IEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess.GetIL(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.APApprovedRequisitionForWOByPanelMember_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APApprovedRequisitionForWOByPanelMember_CustomEntity> list = CreateEntityBuilder<APApprovedRequisitionForWOByPanelMember_CustomEntity>().BuildEntities(reader);

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

        DataTable IAPApprovedRequisitionForWOByPanelMember_CustomDataAccess.GetDT(Int64 employeeID)
        {
            try
            {
                const string SP = "dbo.APApprovedRequisitionForWOByPanelMember_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, employeeID);	

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