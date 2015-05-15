// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 04:30:09




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
    internal sealed partial class CMAbstractMeasurementBookHelper_CustomDataAccess : BaseDataAccess, ICMAbstractMeasurementBookHelper_CustomDataAccess
    {
        #region Constructors

        public CMAbstractMeasurementBookHelper_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity> CreateEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>()
        {
            return (new CMAbstractMeasurementBookHelper_CustomBuilder()) as IEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<CMAbstractMeasurementBookHelper_CustomEntity> ICMAbstractMeasurementBookHelper_CustomDataAccess.GetIL(Int64 projectID, Int64 itemID)
        {
            try
            {
                const string SP = "dbo.CMAbstractMeasurementBookHelper_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
				    Database.AddInParameter(cmd, "@ItemID", DbType.Int64, itemID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMAbstractMeasurementBookHelper_CustomEntity> list = CreateEntityBuilder<CMAbstractMeasurementBookHelper_CustomEntity>().BuildEntities(reader);

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

        DataTable ICMAbstractMeasurementBookHelper_CustomDataAccess.GetDT(Int64 projectID, Int64 itemID)
        {
            try
            {
                const string SP = "dbo.CMAbstractMeasurementBookHelper_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
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
