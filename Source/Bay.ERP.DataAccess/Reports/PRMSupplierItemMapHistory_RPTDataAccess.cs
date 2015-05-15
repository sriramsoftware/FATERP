// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




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
    internal sealed partial class PRMSupplierItemMapHistory_RPTDataAccess : BaseDataAccess, IPRMSupplierItemMapHistory_RPTDataAccess
    {
        #region Constructors

        public PRMSupplierItemMapHistory_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity> CreateEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>()
        {
            return (new PRMSupplierItemMapHistory_RPTBuilder()) as IEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMSupplierItemMapHistory_RPTEntity> IPRMSupplierItemMapHistory_RPTDataAccess.GetIL(Int64 itemID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMapHistory_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ItemID", DbType.Int64, itemID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierItemMapHistory_RPTEntity> list = CreateEntityBuilder<PRMSupplierItemMapHistory_RPTEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierItemMapHistory_RPTDataAccess.GetDT(Int64 itemID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierItemMapHistory_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ItemID", DbType.Int64, itemID);	

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
