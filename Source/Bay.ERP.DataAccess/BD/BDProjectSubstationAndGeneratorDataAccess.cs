// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    internal sealed partial class BDProjectSubstationAndGeneratorDataAccess : BaseDataAccess, IBDProjectSubstationAndGeneratorDataAccess
    {
        #region Constructors

        public BDProjectSubstationAndGeneratorDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectSubstationAndGeneratorEntity> CreateEntityBuilder<BDProjectSubstationAndGeneratorEntity>()
        {
            return (new BDProjectSubstationAndGeneratorBuilder()) as IEntityBuilder<BDProjectSubstationAndGeneratorEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectSubstationAndGeneratorDataAccess.Add(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectSubstationAndGeneratorEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectSubstationAndGeneratorEntity, option);
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

        private Int64 Add(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectSubstationAndGeneratorID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectID);	
                Database.AddInParameter(cmd, "@CapacityOfSubstation", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation);	
                Database.AddInParameter(cmd, "@TotalNumberOfGenerator", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator);	
                Database.AddInParameter(cmd, "@CapacityOfGenerator1", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1);	
                Database.AddInParameter(cmd, "@CapacityOfGenerator2", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2);	
                Database.AddInParameter(cmd, "@CapacityOfGenerator3", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3);	
                Database.AddInParameter(cmd, "@CapacityOfGenerator4", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4);	
                Database.AddInParameter(cmd, "@CapacityOfGenerator5", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.BrandID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectSubstationAndGeneratorID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectID);
                db.AddInParameter(cmd, "@CapacityOfSubstation", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation);
                db.AddInParameter(cmd, "@TotalNumberOfGenerator", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator);
                db.AddInParameter(cmd, "@CapacityOfGenerator1", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1);
                db.AddInParameter(cmd, "@CapacityOfGenerator2", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2);
                db.AddInParameter(cmd, "@CapacityOfGenerator3", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3);
                db.AddInParameter(cmd, "@CapacityOfGenerator4", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4);
                db.AddInParameter(cmd, "@CapacityOfGenerator5", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.BrandID);

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

        IList<Int64> IBDProjectSubstationAndGeneratorDataAccess.Add(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity in bDProjectSubstationAndGeneratorEntityList)
            {
                returnCode = (this as IBDProjectSubstationAndGeneratorDataAccess).Add(bDProjectSubstationAndGeneratorEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectSubstationAndGeneratorDataAccess.Update(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectSubstationAndGeneratorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectSubstationAndGeneratorEntity, filterExpression, option);
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

        private Int64 Update(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectSubstationAndGeneratorID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectSubstationAndGeneratorID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectID);
                Database.AddInParameter(cmd, "@CapacityOfSubstation", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation);
                Database.AddInParameter(cmd, "@TotalNumberOfGenerator", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator);
                Database.AddInParameter(cmd, "@CapacityOfGenerator1", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1);
                Database.AddInParameter(cmd, "@CapacityOfGenerator2", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2);
                Database.AddInParameter(cmd, "@CapacityOfGenerator3", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3);
                Database.AddInParameter(cmd, "@CapacityOfGenerator4", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4);
                Database.AddInParameter(cmd, "@CapacityOfGenerator5", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.BrandID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectSubstationAndGeneratorID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectSubstationAndGeneratorID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.ProjectID);
                db.AddInParameter(cmd, "@CapacityOfSubstation", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfSubstation);
                db.AddInParameter(cmd, "@TotalNumberOfGenerator", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.TotalNumberOfGenerator);
                db.AddInParameter(cmd, "@CapacityOfGenerator1", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator1);
                db.AddInParameter(cmd, "@CapacityOfGenerator2", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator2);
                db.AddInParameter(cmd, "@CapacityOfGenerator3", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator3);
                db.AddInParameter(cmd, "@CapacityOfGenerator4", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator4);
                db.AddInParameter(cmd, "@CapacityOfGenerator5", DbType.Decimal, bDProjectSubstationAndGeneratorEntity.CapacityOfGenerator5);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, bDProjectSubstationAndGeneratorEntity.BrandID);

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

        IList<Int64> IBDProjectSubstationAndGeneratorDataAccess.Update(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity in bDProjectSubstationAndGeneratorEntityList)
            {
                returnCode = (this as IBDProjectSubstationAndGeneratorDataAccess).Update(bDProjectSubstationAndGeneratorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectSubstationAndGeneratorDataAccess.Delete(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectSubstationAndGeneratorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectSubstationAndGeneratorEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

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
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectSubstationAndGeneratorEntity already exists. Please specify another BDProjectSubstationAndGeneratorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectSubstationAndGenerator_SET";

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

        IList<Int64> IBDProjectSubstationAndGeneratorDataAccess.Delete(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity in bDProjectSubstationAndGeneratorEntityList)
            {
                returnCode = (this as IBDProjectSubstationAndGeneratorDataAccess).Delete(bDProjectSubstationAndGeneratorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectSubstationAndGeneratorEntity> IBDProjectSubstationAndGeneratorDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectSubstationAndGenerator_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectSubstationAndGeneratorEntity> list = CreateEntityBuilder<BDProjectSubstationAndGeneratorEntity>().BuildEntities(reader);

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

        DataTable IBDProjectSubstationAndGeneratorDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectSubstationAndGenerator_GET";

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
