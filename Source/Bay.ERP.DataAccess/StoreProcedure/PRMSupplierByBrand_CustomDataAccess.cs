// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2012, 03:22:36




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
    internal sealed partial class PRMSupplierByBrand_CustomDataAccess : BaseDataAccess, IPRMSupplierByBrand_CustomDataAccess
    {
        #region Constructors

        public PRMSupplierByBrand_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierByBrand_CustomEntity> CreateEntityBuilder<PRMSupplierByBrand_CustomEntity>()
        {
            return (new PRMSupplierByBrand_CustomBuilder()) as IEntityBuilder<PRMSupplierByBrand_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMSupplierByBrand_CustomEntity> IPRMSupplierByBrand_CustomDataAccess.GetIL(Int64 brandID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierByBrand_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BrandID", DbType.Int64, brandID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierByBrand_CustomEntity> list = CreateEntityBuilder<PRMSupplierByBrand_CustomEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierByBrand_CustomDataAccess.GetDT(Int64 brandID)
        {
            try
            {
                const string SP = "dbo.PRMSupplierByBrand_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BrandID", DbType.Int64, brandID);	

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
