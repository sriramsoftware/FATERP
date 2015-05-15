// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Dec-2011, 11:00:45




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
    internal sealed partial class BDProjectAddressInfoDataAccess : BaseDataAccess, IBDProjectAddressInfoDataAccess
    {
        #region Constructors

        public BDProjectAddressInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectAddressInfoEntity> CreateEntityBuilder<BDProjectAddressInfoEntity>()
        {
            return (new BDProjectAddressInfoBuilder()) as IEntityBuilder<BDProjectAddressInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectAddressInfoDataAccess.Add(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectAddressInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectAddressInfoEntity, option);
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

        private Int64 Add(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectAddressInfoID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAddressInfoEntity.ProjectID);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProjectAddressInfoEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProjectAddressInfoEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, bDProjectAddressInfoEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, bDProjectAddressInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, bDProjectAddressInfoEntity.ZipCode);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectAddressInfoID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAddressInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProjectAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProjectAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, bDProjectAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, bDProjectAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, bDProjectAddressInfoEntity.ZipCode);

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

        IList<Int64> IBDProjectAddressInfoDataAccess.Add(IList<BDProjectAddressInfoEntity> bDProjectAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectAddressInfoEntity bDProjectAddressInfoEntity in bDProjectAddressInfoEntityList)
            {
                returnCode = (this as IBDProjectAddressInfoDataAccess).Add(bDProjectAddressInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectAddressInfoDataAccess.Update(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectAddressInfoEntity, filterExpression, option);
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

        private Int64 Update(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectAddressInfoID", DbType.Int64, bDProjectAddressInfoEntity.ProjectAddressInfoID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAddressInfoEntity.ProjectID);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProjectAddressInfoEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProjectAddressInfoEntity.AddressLine2);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, bDProjectAddressInfoEntity.CountryID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, bDProjectAddressInfoEntity.CityID);
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, bDProjectAddressInfoEntity.ZipCode);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectAddressInfoID", DbType.Int64, bDProjectAddressInfoEntity.ProjectAddressInfoID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectAddressInfoEntity.ProjectID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDProjectAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDProjectAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, bDProjectAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, bDProjectAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, bDProjectAddressInfoEntity.ZipCode);

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

        IList<Int64> IBDProjectAddressInfoDataAccess.Update(IList<BDProjectAddressInfoEntity> bDProjectAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectAddressInfoEntity bDProjectAddressInfoEntity in bDProjectAddressInfoEntityList)
            {
                returnCode = (this as IBDProjectAddressInfoDataAccess).Update(bDProjectAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectAddressInfoDataAccess.Delete(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectAddressInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

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
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectAddressInfoEntity already exists. Please specify another BDProjectAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectAddressInfoEntity bDProjectAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectAddressInfo_SET";

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

        IList<Int64> IBDProjectAddressInfoDataAccess.Delete(IList<BDProjectAddressInfoEntity> bDProjectAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectAddressInfoEntity bDProjectAddressInfoEntity in bDProjectAddressInfoEntityList)
            {
                returnCode = (this as IBDProjectAddressInfoDataAccess).Delete(bDProjectAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectAddressInfoEntity> IBDProjectAddressInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAddressInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectAddressInfoEntity> list = CreateEntityBuilder<BDProjectAddressInfoEntity>().BuildEntities(reader);

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

        DataTable IBDProjectAddressInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectAddressInfo_GET";

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
