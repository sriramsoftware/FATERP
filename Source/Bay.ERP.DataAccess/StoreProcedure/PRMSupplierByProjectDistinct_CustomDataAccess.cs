// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




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
    internal sealed partial class PRMSupplierByProjectDistinct_CustomDataAccess : BaseDataAccess, IPRMSupplierByProjectDistinct_CustomDataAccess
    {
        #region Constructors

        public PRMSupplierByProjectDistinct_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity> CreateEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>()
        {
            return (new PRMSupplierByProjectDistinct_CustomBuilder()) as IEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMSupplierByProjectDistinct_CustomEntity> IPRMSupplierByProjectDistinct_CustomDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierByProjectDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierByProjectDistinct_CustomEntity> list = CreateEntityBuilder<PRMSupplierByProjectDistinct_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierByProjectDistinct_CustomDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierByProjectDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

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
