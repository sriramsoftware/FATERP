// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 08:31:04




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
    internal sealed partial class BDOperatorAddressInfoDataAccess : BaseDataAccess, IBDOperatorAddressInfoDataAccess
    {
        #region Constructors

        public BDOperatorAddressInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDOperatorAddressInfoEntity> CreateEntityBuilder<BDOperatorAddressInfoEntity>()
        {
            return (new BDOperatorAddressInfoBuilder()) as IEntityBuilder<BDOperatorAddressInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDOperatorAddressInfoDataAccess.Add(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDOperatorAddressInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDOperatorAddressInfoEntity, option);
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

        private Int64 Add(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "OperatorAddressInfoID");

                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorID);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorAddressInfoEntity.WebLink);	
                Database.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressTypeID);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDOperatorAddressInfoEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDOperatorAddressInfoEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, bDOperatorAddressInfoEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, bDOperatorAddressInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, bDOperatorAddressInfoEntity.ZipCode);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorAddressInfoEntity.Phone);	
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorAddressInfoEntity.Email);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "OperatorAddressInfoID", db);

                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorID);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorAddressInfoEntity.WebLink);
                db.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressTypeID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDOperatorAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDOperatorAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, bDOperatorAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, bDOperatorAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, bDOperatorAddressInfoEntity.ZipCode);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorAddressInfoEntity.Email);

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

        IList<Int64> IBDOperatorAddressInfoDataAccess.Add(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity in bDOperatorAddressInfoEntityList)
            {
                returnCode = (this as IBDOperatorAddressInfoDataAccess).Add(bDOperatorAddressInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDOperatorAddressInfoDataAccess.Update(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDOperatorAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDOperatorAddressInfoEntity, filterExpression, option);
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

        private Int64 Update(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@OperatorAddressInfoID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressInfoID);
                Database.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorID);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorAddressInfoEntity.WebLink);
                Database.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressTypeID);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, bDOperatorAddressInfoEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, bDOperatorAddressInfoEntity.AddressLine2);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, bDOperatorAddressInfoEntity.CountryID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, bDOperatorAddressInfoEntity.CityID);
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, bDOperatorAddressInfoEntity.ZipCode);
                Database.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorAddressInfoEntity.Phone);
                Database.AddInParameter(cmd, "@Email", DbType.String, bDOperatorAddressInfoEntity.Email);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@OperatorAddressInfoID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressInfoID);
                db.AddInParameter(cmd, "@OperatorID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorID);
                db.AddInParameter(cmd, "@WebLink", DbType.String, bDOperatorAddressInfoEntity.WebLink);
                db.AddInParameter(cmd, "@OperatorAddressTypeID", DbType.Int64, bDOperatorAddressInfoEntity.OperatorAddressTypeID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, bDOperatorAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, bDOperatorAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, bDOperatorAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, bDOperatorAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, bDOperatorAddressInfoEntity.ZipCode);
                db.AddInParameter(cmd, "@Phone", DbType.String, bDOperatorAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, bDOperatorAddressInfoEntity.Email);

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

        IList<Int64> IBDOperatorAddressInfoDataAccess.Update(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity in bDOperatorAddressInfoEntityList)
            {
                returnCode = (this as IBDOperatorAddressInfoDataAccess).Update(bDOperatorAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDOperatorAddressInfoDataAccess.Delete(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDOperatorAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDOperatorAddressInfoEntity, filterExpression, option);
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

        private Int64 Delete(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

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
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDOperatorAddressInfoEntity already exists. Please specify another BDOperatorAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDOperatorAddressInfo_SET";

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

        IList<Int64> IBDOperatorAddressInfoDataAccess.Delete(IList<BDOperatorAddressInfoEntity> bDOperatorAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDOperatorAddressInfoEntity bDOperatorAddressInfoEntity in bDOperatorAddressInfoEntityList)
            {
                returnCode = (this as IBDOperatorAddressInfoDataAccess).Delete(bDOperatorAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDOperatorAddressInfoEntity> IBDOperatorAddressInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperatorAddressInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDOperatorAddressInfoEntity> list = CreateEntityBuilder<BDOperatorAddressInfoEntity>().BuildEntities(reader);

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

        DataTable IBDOperatorAddressInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDOperatorAddressInfo_GET";

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
