// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




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
    internal sealed partial class CMBillMaterialReceiveMeasurementBookMapDataAccess : BaseDataAccess, ICMBillMaterialReceiveMeasurementBookMapDataAccess
    {
        #region Constructors

        public CMBillMaterialReceiveMeasurementBookMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity> CreateEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>()
        {
            return (new CMBillMaterialReceiveMeasurementBookMapBuilder()) as IEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMBillMaterialReceiveMeasurementBookMapDataAccess.Add(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMBillMaterialReceiveMeasurementBookMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMBillMaterialReceiveMeasurementBookMapEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BillMaterialReceiveMeasurementBookMapID");

                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillID);	
                Database.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID);	
                Database.AddInParameter(cmd, "@MaterialReceiveItemMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID);	
                Database.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID);	
                Database.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID);	
                Database.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillMaterialReceiveMeasurementBookMapEntity.BillPrice);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BillMaterialReceiveMeasurementBookMapID", db);

                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillID);
                db.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID);
                db.AddInParameter(cmd, "@MaterialReceiveItemMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID);
                db.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID);
                db.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID);
                db.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillMaterialReceiveMeasurementBookMapEntity.BillPrice);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapDataAccess.Add(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity in cMBillMaterialReceiveMeasurementBookMapEntityList)
            {
                returnCode = (this as ICMBillMaterialReceiveMeasurementBookMapDataAccess).Add(cMBillMaterialReceiveMeasurementBookMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMBillMaterialReceiveMeasurementBookMapDataAccess.Update(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BillMaterialReceiveMeasurementBookMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillMaterialReceiveMeasurementBookMapID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillID);
                Database.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID);
                Database.AddInParameter(cmd, "@MaterialReceiveItemMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID);
                Database.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID);
                Database.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID);
                Database.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillMaterialReceiveMeasurementBookMapEntity.BillPrice);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BillMaterialReceiveMeasurementBookMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillMaterialReceiveMeasurementBookMapID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.BillID);
                db.AddInParameter(cmd, "@MaterialReceiveID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveID);
                db.AddInParameter(cmd, "@MaterialReceiveItemMapID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MaterialReceiveItemMapID);
                db.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookID);
                db.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMBillMaterialReceiveMeasurementBookMapEntity.MeasurementBookDetailID);
                db.AddInParameter(cmd, "@BillPrice", DbType.Decimal, cMBillMaterialReceiveMeasurementBookMapEntity.BillPrice);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapDataAccess.Update(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity in cMBillMaterialReceiveMeasurementBookMapEntityList)
            {
                returnCode = (this as ICMBillMaterialReceiveMeasurementBookMapDataAccess).Update(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMBillMaterialReceiveMeasurementBookMapDataAccess.Delete(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillMaterialReceiveMeasurementBookMapEntity already exists. Please specify another CMBillMaterialReceiveMeasurementBookMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapDataAccess.Delete(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity in cMBillMaterialReceiveMeasurementBookMapEntityList)
            {
                returnCode = (this as ICMBillMaterialReceiveMeasurementBookMapDataAccess).Delete(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMBillMaterialReceiveMeasurementBookMapEntity> ICMBillMaterialReceiveMeasurementBookMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillMaterialReceiveMeasurementBookMapEntity> list = CreateEntityBuilder<CMBillMaterialReceiveMeasurementBookMapEntity>().BuildEntities(reader);

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

        DataTable ICMBillMaterialReceiveMeasurementBookMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillMaterialReceiveMeasurementBookMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

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
