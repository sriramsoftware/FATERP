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
    internal sealed partial class PRMRequisitionBySupplierDistinct_CustomDataAccess : BaseDataAccess, IPRMRequisitionBySupplierDistinct_CustomDataAccess
    {
        #region Constructors

        public PRMRequisitionBySupplierDistinct_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity> CreateEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>()
        {
            return (new PRMRequisitionBySupplierDistinct_CustomBuilder()) as IEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMRequisitionBySupplierDistinct_CustomEntity> IPRMRequisitionBySupplierDistinct_CustomDataAccess.GetIL(Int64 supplierID)
        {
            try
            {
                const string SP = "dbo.PRMRequisitionBySupplierDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, supplierID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMRequisitionBySupplierDistinct_CustomEntity> list = CreateEntityBuilder<PRMRequisitionBySupplierDistinct_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMRequisitionBySupplierDistinct_CustomDataAccess.GetDT(Int64 supplierID)
        {
            try
            {
                const string SP = "dbo.PRMRequisitionBySupplierDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, supplierID);	

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
