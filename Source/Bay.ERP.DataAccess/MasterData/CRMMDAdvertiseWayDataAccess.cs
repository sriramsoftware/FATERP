// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    internal sealed partial class CRMMDAdvertiseWayDataAccess : BaseDataAccess, ICRMMDAdvertiseWayDataAccess
    {
        #region Constructors

        public CRMMDAdvertiseWayDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMMDAdvertiseWayEntity> CreateEntityBuilder<CRMMDAdvertiseWayEntity>()
        {
            return (new CRMMDAdvertiseWayBuilder()) as IEntityBuilder<CRMMDAdvertiseWayEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMMDAdvertiseWayDataAccess.Add(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMMDAdvertiseWayEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMMDAdvertiseWayEntity, option);
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

        private Int64 Add(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AdvertiseWayID");

                Database.AddInParameter(cmd, "@Name", DbType.String, cRMMDAdvertiseWayEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMMDAdvertiseWayEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAdvertiseWayEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AdvertiseWayID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, cRMMDAdvertiseWayEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMMDAdvertiseWayEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAdvertiseWayEntity.IsRemoved);

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

        IList<Int64> ICRMMDAdvertiseWayDataAccess.Add(IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity in cRMMDAdvertiseWayEntityList)
            {
                returnCode = (this as ICRMMDAdvertiseWayDataAccess).Add(cRMMDAdvertiseWayEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMMDAdvertiseWayDataAccess.Update(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMMDAdvertiseWayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMMDAdvertiseWayEntity, filterExpression, option);
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

        private Int64 Update(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMMDAdvertiseWayEntity.AdvertiseWayID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMMDAdvertiseWayEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMMDAdvertiseWayEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAdvertiseWayEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AdvertiseWayID", DbType.Int64, cRMMDAdvertiseWayEntity.AdvertiseWayID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMMDAdvertiseWayEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMMDAdvertiseWayEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAdvertiseWayEntity.IsRemoved);

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

        IList<Int64> ICRMMDAdvertiseWayDataAccess.Update(IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity in cRMMDAdvertiseWayEntityList)
            {
                returnCode = (this as ICRMMDAdvertiseWayDataAccess).Update(cRMMDAdvertiseWayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMMDAdvertiseWayDataAccess.Delete(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMMDAdvertiseWayEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMMDAdvertiseWayEntity, filterExpression, option);
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

        private Int64 Delete(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

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
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAdvertiseWayEntity already exists. Please specify another CRMMDAdvertiseWayEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAdvertiseWay_SET";

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

        IList<Int64> ICRMMDAdvertiseWayDataAccess.Delete(IList<CRMMDAdvertiseWayEntity> cRMMDAdvertiseWayEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMMDAdvertiseWayEntity cRMMDAdvertiseWayEntity in cRMMDAdvertiseWayEntityList)
            {
                returnCode = (this as ICRMMDAdvertiseWayDataAccess).Delete(cRMMDAdvertiseWayEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMMDAdvertiseWayEntity> ICRMMDAdvertiseWayDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMMDAdvertiseWay_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMMDAdvertiseWayEntity> list = CreateEntityBuilder<CRMMDAdvertiseWayEntity>().BuildEntities(reader);

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

        DataTable ICRMMDAdvertiseWayDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMMDAdvertiseWay_GET";

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
