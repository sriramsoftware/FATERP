// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2012, 11:18:25




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
    internal sealed partial class CMAbstractMeasurementBook_CustomDataAccess : BaseDataAccess, ICMAbstractMeasurementBook_CustomDataAccess
    {
        #region Constructors

        public CMAbstractMeasurementBook_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMAbstractMeasurementBook_CustomEntity> CreateEntityBuilder<CMAbstractMeasurementBook_CustomEntity>()
        {
            return (new CMAbstractMeasurementBook_CustomBuilder()) as IEntityBuilder<CMAbstractMeasurementBook_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<CMAbstractMeasurementBook_CustomEntity> ICMAbstractMeasurementBook_CustomDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.CMAbstractMeasurementBook_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMAbstractMeasurementBook_CustomEntity> list = CreateEntityBuilder<CMAbstractMeasurementBook_CustomEntity>().BuildEntities(reader);

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

        DataTable ICMAbstractMeasurementBook_CustomDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.CMAbstractMeasurementBook_Custom";

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
