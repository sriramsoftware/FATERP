// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 09:34:03




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
    internal sealed partial class ACTaxTypeDataAccess : BaseDataAccess, IACTaxTypeDataAccess
    {
        #region Constructors

        public ACTaxTypeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTaxTypeEntity> CreateEntityBuilder<ACTaxTypeEntity>()
        {
            return (new ACTaxTypeBuilder()) as IEntityBuilder<ACTaxTypeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACTaxTypeDataAccess.Add(ACTaxTypeEntity aCTaxTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCTaxTypeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCTaxTypeEntity, option);
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

        private Int64 Add(ACTaxTypeEntity aCTaxTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TaxTypeID");

                Database.AddInParameter(cmd, "@Name", DbType.String, aCTaxTypeEntity.Name);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, aCTaxTypeEntity.Rate);	
                Database.AddInParameter(cmd, "@Description", DbType.String, aCTaxTypeEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCTaxTypeEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACTaxTypeEntity aCTaxTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TaxTypeID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, aCTaxTypeEntity.Name);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, aCTaxTypeEntity.Rate);
                db.AddInParameter(cmd, "@Description", DbType.String, aCTaxTypeEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCTaxTypeEntity.IsRemoved);

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

        IList<Int64> IACTaxTypeDataAccess.Add(IList<ACTaxTypeEntity> aCTaxTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACTaxTypeEntity aCTaxTypeEntity in aCTaxTypeEntityList)
            {
                returnCode = (this as IACTaxTypeDataAccess).Add(aCTaxTypeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACTaxTypeDataAccess.Update(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCTaxTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCTaxTypeEntity, filterExpression, option);
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

        private Int64 Update(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCTaxTypeEntity.TaxTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, aCTaxTypeEntity.Name);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, aCTaxTypeEntity.Rate);
                Database.AddInParameter(cmd, "@Description", DbType.String, aCTaxTypeEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCTaxTypeEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TaxTypeID", DbType.Int64, aCTaxTypeEntity.TaxTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, aCTaxTypeEntity.Name);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, aCTaxTypeEntity.Rate);
                db.AddInParameter(cmd, "@Description", DbType.String, aCTaxTypeEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCTaxTypeEntity.IsRemoved);

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

        IList<Int64> IACTaxTypeDataAccess.Update(IList<ACTaxTypeEntity> aCTaxTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACTaxTypeEntity aCTaxTypeEntity in aCTaxTypeEntityList)
            {
                returnCode = (this as IACTaxTypeDataAccess).Update(aCTaxTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACTaxTypeDataAccess.Delete(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCTaxTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCTaxTypeEntity, filterExpression, option);
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

        private Int64 Delete(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

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
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTaxTypeEntity already exists. Please specify another ACTaxTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACTaxTypeEntity aCTaxTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTaxType_SET";

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

        IList<Int64> IACTaxTypeDataAccess.Delete(IList<ACTaxTypeEntity> aCTaxTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACTaxTypeEntity aCTaxTypeEntity in aCTaxTypeEntityList)
            {
                returnCode = (this as IACTaxTypeDataAccess).Delete(aCTaxTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACTaxTypeEntity> IACTaxTypeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTaxType_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTaxTypeEntity> list = CreateEntityBuilder<ACTaxTypeEntity>().BuildEntities(reader);

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

        DataTable IACTaxTypeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTaxType_GET";

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
