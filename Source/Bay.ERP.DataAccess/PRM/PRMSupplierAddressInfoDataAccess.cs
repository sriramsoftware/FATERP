// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Feb-2012, 05:41:59




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
    internal sealed partial class PRMSupplierAddressInfoDataAccess : BaseDataAccess, IPRMSupplierAddressInfoDataAccess
    {
        #region Constructors

        public PRMSupplierAddressInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMSupplierAddressInfoEntity> CreateEntityBuilder<PRMSupplierAddressInfoEntity>()
        {
            return (new PRMSupplierAddressInfoBuilder()) as IEntityBuilder<PRMSupplierAddressInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMSupplierAddressInfoDataAccess.Add(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMSupplierAddressInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMSupplierAddressInfoEntity, option);
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

        private Int64 Add(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SupplierAddressInfoID");

                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierID);	
                Database.AddInParameter(cmd, "@SupplierAddressTypeID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressTypeID);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, pRMSupplierAddressInfoEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, pRMSupplierAddressInfoEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMSupplierAddressInfoEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, pRMSupplierAddressInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, pRMSupplierAddressInfoEntity.ZipCode);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierAddressInfoEntity.Phone);	
                Database.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierAddressInfoEntity.Email);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierAddressInfoEntity.WebLink);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SupplierAddressInfoID", db);

                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierID);
                db.AddInParameter(cmd, "@SupplierAddressTypeID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressTypeID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, pRMSupplierAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, pRMSupplierAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMSupplierAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, pRMSupplierAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, pRMSupplierAddressInfoEntity.ZipCode);
                db.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierAddressInfoEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierAddressInfoEntity.WebLink);

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

        IList<Int64> IPRMSupplierAddressInfoDataAccess.Add(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity in pRMSupplierAddressInfoEntityList)
            {
                returnCode = (this as IPRMSupplierAddressInfoDataAccess).Add(pRMSupplierAddressInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMSupplierAddressInfoDataAccess.Update(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMSupplierAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMSupplierAddressInfoEntity, filterExpression, option);
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

        private Int64 Update(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SupplierAddressInfoID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressInfoID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierID);
                Database.AddInParameter(cmd, "@SupplierAddressTypeID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressTypeID);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, pRMSupplierAddressInfoEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, pRMSupplierAddressInfoEntity.AddressLine2);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMSupplierAddressInfoEntity.CountryID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, pRMSupplierAddressInfoEntity.CityID);
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, pRMSupplierAddressInfoEntity.ZipCode);
                Database.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierAddressInfoEntity.Phone);
                Database.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierAddressInfoEntity.Email);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierAddressInfoEntity.WebLink);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SupplierAddressInfoID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressInfoID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierID);
                db.AddInParameter(cmd, "@SupplierAddressTypeID", DbType.Int64, pRMSupplierAddressInfoEntity.SupplierAddressTypeID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, pRMSupplierAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, pRMSupplierAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMSupplierAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, pRMSupplierAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, pRMSupplierAddressInfoEntity.ZipCode);
                db.AddInParameter(cmd, "@Phone", DbType.String, pRMSupplierAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, pRMSupplierAddressInfoEntity.Email);
                db.AddInParameter(cmd, "@WebLink", DbType.String, pRMSupplierAddressInfoEntity.WebLink);

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

        IList<Int64> IPRMSupplierAddressInfoDataAccess.Update(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity in pRMSupplierAddressInfoEntityList)
            {
                returnCode = (this as IPRMSupplierAddressInfoDataAccess).Update(pRMSupplierAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMSupplierAddressInfoDataAccess.Delete(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMSupplierAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMSupplierAddressInfoEntity, filterExpression, option);
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

        private Int64 Delete(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

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
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMSupplierAddressInfoEntity already exists. Please specify another PRMSupplierAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMSupplierAddressInfo_SET";

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

        IList<Int64> IPRMSupplierAddressInfoDataAccess.Delete(IList<PRMSupplierAddressInfoEntity> pRMSupplierAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMSupplierAddressInfoEntity pRMSupplierAddressInfoEntity in pRMSupplierAddressInfoEntityList)
            {
                returnCode = (this as IPRMSupplierAddressInfoDataAccess).Delete(pRMSupplierAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMSupplierAddressInfoEntity> IPRMSupplierAddressInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierAddressInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMSupplierAddressInfoEntity> list = CreateEntityBuilder<PRMSupplierAddressInfoEntity>().BuildEntities(reader);

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

        DataTable IPRMSupplierAddressInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMSupplierAddressInfo_GET";

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
