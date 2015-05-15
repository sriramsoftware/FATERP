// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 03:37:27




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
    internal sealed partial class HREmployeeSupervisorMapDataAccess : BaseDataAccess, IHREmployeeSupervisorMapDataAccess
    {
        #region Constructors

        public HREmployeeSupervisorMapDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSupervisorMapEntity> CreateEntityBuilder<HREmployeeSupervisorMapEntity>()
        {
            return (new HREmployeeSupervisorMapBuilder()) as IEntityBuilder<HREmployeeSupervisorMapEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSupervisorMapDataAccess.Add(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSupervisorMapEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSupervisorMapEntity, option);
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

        private Int64 Add(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSupervisorMapID");

                Database.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hREmployeeSupervisorMapEntity.SessionCategoryID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorTypeID);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorEmployeeID);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.SupervisorEmployeeCode);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeSupervisorMapEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSupervisorMapEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSupervisorMapID", db);

                db.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hREmployeeSupervisorMapEntity.SessionCategoryID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.EmployeeCode);
                db.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorTypeID);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.SupervisorEmployeeCode);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeSupervisorMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSupervisorMapEntity.CreateDate);

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

        IList<Int64> IHREmployeeSupervisorMapDataAccess.Add(IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity in hREmployeeSupervisorMapEntityList)
            {
                returnCode = (this as IHREmployeeSupervisorMapDataAccess).Add(hREmployeeSupervisorMapEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSupervisorMapDataAccess.Update(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSupervisorMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSupervisorMapEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSupervisorMapID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeSupervisorMapID);
                Database.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hREmployeeSupervisorMapEntity.SessionCategoryID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorTypeID);
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorEmployeeID);
                Database.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.SupervisorEmployeeCode);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeSupervisorMapEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSupervisorMapEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSupervisorMapID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeSupervisorMapID);
                db.AddInParameter(cmd, "@SessionCategoryID", DbType.Int64, hREmployeeSupervisorMapEntity.SessionCategoryID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.EmployeeID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.EmployeeCode);
                db.AddInParameter(cmd, "@SupervisorTypeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorTypeID);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, hREmployeeSupervisorMapEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@SupervisorEmployeeCode", DbType.String, hREmployeeSupervisorMapEntity.SupervisorEmployeeCode);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeSupervisorMapEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeSupervisorMapEntity.CreateDate);

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

        IList<Int64> IHREmployeeSupervisorMapDataAccess.Update(IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity in hREmployeeSupervisorMapEntityList)
            {
                returnCode = (this as IHREmployeeSupervisorMapDataAccess).Update(hREmployeeSupervisorMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSupervisorMapDataAccess.Delete(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSupervisorMapEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSupervisorMapEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

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
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSupervisorMapEntity already exists. Please specify another HREmployeeSupervisorMapEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSupervisorMap_SET";

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

        IList<Int64> IHREmployeeSupervisorMapDataAccess.Delete(IList<HREmployeeSupervisorMapEntity> hREmployeeSupervisorMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSupervisorMapEntity hREmployeeSupervisorMapEntity in hREmployeeSupervisorMapEntityList)
            {
                returnCode = (this as IHREmployeeSupervisorMapDataAccess).Delete(hREmployeeSupervisorMapEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSupervisorMapEntity> IHREmployeeSupervisorMapDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSupervisorMap_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSupervisorMapEntity> list = CreateEntityBuilder<HREmployeeSupervisorMapEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSupervisorMapDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSupervisorMap_GET";

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
