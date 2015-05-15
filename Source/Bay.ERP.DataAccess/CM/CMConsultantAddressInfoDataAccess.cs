// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    internal sealed partial class CMConsultantAddressInfoDataAccess : BaseDataAccess, ICMConsultantAddressInfoDataAccess
    {
        #region Constructors

        public CMConsultantAddressInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMConsultantAddressInfoEntity> CreateEntityBuilder<CMConsultantAddressInfoEntity>()
        {
            return (new CMConsultantAddressInfoBuilder()) as IEntityBuilder<CMConsultantAddressInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMConsultantAddressInfoDataAccess.Add(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMConsultantAddressInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMConsultantAddressInfoEntity, option);
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

        private Int64 Add(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ConsultantAddressInfoID");

                Database.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantID);	
                Database.AddInParameter(cmd, "@AddressTypeID", DbType.Int64, cMConsultantAddressInfoEntity.AddressTypeID);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantAddressInfoEntity.Phone);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, cMConsultantAddressInfoEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cMConsultantAddressInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cMConsultantAddressInfoEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cMConsultantAddressInfoEntity.AddressLine2);	
                Database.AddInParameter(cmd, "@Fax", DbType.String, cMConsultantAddressInfoEntity.Fax);	
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, cMConsultantAddressInfoEntity.ZipCode);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ConsultantAddressInfoID", db);

                db.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantID);
                db.AddInParameter(cmd, "@AddressTypeID", DbType.Int64, cMConsultantAddressInfoEntity.AddressTypeID);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, cMConsultantAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cMConsultantAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cMConsultantAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cMConsultantAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@Fax", DbType.String, cMConsultantAddressInfoEntity.Fax);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, cMConsultantAddressInfoEntity.ZipCode);

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

        IList<Int64> ICMConsultantAddressInfoDataAccess.Add(IList<CMConsultantAddressInfoEntity> cMConsultantAddressInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity in cMConsultantAddressInfoEntityList)
            {
                returnCode = (this as ICMConsultantAddressInfoDataAccess).Add(cMConsultantAddressInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMConsultantAddressInfoDataAccess.Update(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMConsultantAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMConsultantAddressInfoEntity, filterExpression, option);
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

        private Int64 Update(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ConsultantAddressInfoID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantAddressInfoID);
                Database.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantID);
                Database.AddInParameter(cmd, "@AddressTypeID", DbType.Int64, cMConsultantAddressInfoEntity.AddressTypeID);
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantAddressInfoEntity.Phone);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, cMConsultantAddressInfoEntity.CountryID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cMConsultantAddressInfoEntity.CityID);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cMConsultantAddressInfoEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cMConsultantAddressInfoEntity.AddressLine2);
                Database.AddInParameter(cmd, "@Fax", DbType.String, cMConsultantAddressInfoEntity.Fax);
                Database.AddInParameter(cmd, "@ZipCode", DbType.String, cMConsultantAddressInfoEntity.ZipCode);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ConsultantAddressInfoID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantAddressInfoID);
                db.AddInParameter(cmd, "@ConsultantID", DbType.Int64, cMConsultantAddressInfoEntity.ConsultantID);
                db.AddInParameter(cmd, "@AddressTypeID", DbType.Int64, cMConsultantAddressInfoEntity.AddressTypeID);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMConsultantAddressInfoEntity.Phone);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, cMConsultantAddressInfoEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cMConsultantAddressInfoEntity.CityID);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cMConsultantAddressInfoEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cMConsultantAddressInfoEntity.AddressLine2);
                db.AddInParameter(cmd, "@Fax", DbType.String, cMConsultantAddressInfoEntity.Fax);
                db.AddInParameter(cmd, "@ZipCode", DbType.String, cMConsultantAddressInfoEntity.ZipCode);

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

        IList<Int64> ICMConsultantAddressInfoDataAccess.Update(IList<CMConsultantAddressInfoEntity> cMConsultantAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity in cMConsultantAddressInfoEntityList)
            {
                returnCode = (this as ICMConsultantAddressInfoDataAccess).Update(cMConsultantAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMConsultantAddressInfoDataAccess.Delete(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMConsultantAddressInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMConsultantAddressInfoEntity, filterExpression, option);
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

        private Int64 Delete(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

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
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMConsultantAddressInfoEntity already exists. Please specify another CMConsultantAddressInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMConsultantAddressInfo_SET";

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

        IList<Int64> ICMConsultantAddressInfoDataAccess.Delete(IList<CMConsultantAddressInfoEntity> cMConsultantAddressInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMConsultantAddressInfoEntity cMConsultantAddressInfoEntity in cMConsultantAddressInfoEntityList)
            {
                returnCode = (this as ICMConsultantAddressInfoDataAccess).Delete(cMConsultantAddressInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMConsultantAddressInfoEntity> ICMConsultantAddressInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultantAddressInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMConsultantAddressInfoEntity> list = CreateEntityBuilder<CMConsultantAddressInfoEntity>().BuildEntities(reader);

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

        DataTable ICMConsultantAddressInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMConsultantAddressInfo_GET";

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
