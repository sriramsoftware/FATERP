// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2013, 09:29:16




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
    internal sealed partial class ACTDSDataAccess : BaseDataAccess, IACTDSDataAccess
    {
        #region Constructors

        public ACTDSDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTDSEntity> CreateEntityBuilder<ACTDSEntity>()
        {
            return (new ACTDSBuilder()) as IEntityBuilder<ACTDSEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACTDSDataAccess.Add(ACTDSEntity aCTDSEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCTDSEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCTDSEntity, option);
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

        private Int64 Add(ACTDSEntity aCTDSEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TDSID");

                Database.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSEntity.TDSCategoryID);	
                Database.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSEntity.StartValue);	
                Database.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSEntity.EndValue);	
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSEntity.Tax);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACTDSEntity aCTDSEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TDSID", db);

                db.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSEntity.TDSCategoryID);
                db.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSEntity.StartValue);
                db.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSEntity.EndValue);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSEntity.Tax);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSEntity.Remarks);

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

        IList<Int64> IACTDSDataAccess.Add(IList<ACTDSEntity> aCTDSEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACTDSEntity aCTDSEntity in aCTDSEntityList)
            {
                returnCode = (this as IACTDSDataAccess).Add(aCTDSEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACTDSDataAccess.Update(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCTDSEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCTDSEntity, filterExpression, option);
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

        private Int64 Update(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TDSID", DbType.Int64, aCTDSEntity.TDSID);
                Database.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSEntity.TDSCategoryID);
                Database.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSEntity.StartValue);
                Database.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSEntity.EndValue);
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSEntity.Tax);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TDSID", DbType.Int64, aCTDSEntity.TDSID);
                db.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSEntity.TDSCategoryID);
                db.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSEntity.StartValue);
                db.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSEntity.EndValue);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSEntity.Tax);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSEntity.Remarks);

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

        IList<Int64> IACTDSDataAccess.Update(IList<ACTDSEntity> aCTDSEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACTDSEntity aCTDSEntity in aCTDSEntityList)
            {
                returnCode = (this as IACTDSDataAccess).Update(aCTDSEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACTDSDataAccess.Delete(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCTDSEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCTDSEntity, filterExpression, option);
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

        private Int64 Delete(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

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
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSEntity already exists. Please specify another ACTDSEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACTDSEntity aCTDSEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDS_SET";

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

        IList<Int64> IACTDSDataAccess.Delete(IList<ACTDSEntity> aCTDSEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACTDSEntity aCTDSEntity in aCTDSEntityList)
            {
                returnCode = (this as IACTDSDataAccess).Delete(aCTDSEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACTDSEntity> IACTDSDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTDS_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTDSEntity> list = CreateEntityBuilder<ACTDSEntity>().BuildEntities(reader);

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

        DataTable IACTDSDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTDS_GET";

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
