// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HREmployeeDrivingLicenseInformationDataAccess : BaseDataAccess, IHREmployeeDrivingLicenseInformationDataAccess
    {
        #region Constructors

        public HREmployeeDrivingLicenseInformationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeDrivingLicenseInformationEntity> CreateEntityBuilder<HREmployeeDrivingLicenseInformationEntity>()
        {
            return (new HREmployeeDrivingLicenseInformationBuilder()) as IEntityBuilder<HREmployeeDrivingLicenseInformationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeDrivingLicenseInformationDataAccess.Add(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeDrivingLicenseInformationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeDrivingLicenseInformationEntity, option);
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

        private Int64 Add(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeDrivingLicenseInformationID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@DrivingLicenseCategoryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID);	
                Database.AddInParameter(cmd, "@LicenseNumber", DbType.String, hREmployeeDrivingLicenseInformationEntity.LicenseNumber);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityName", DbType.String, hREmployeeDrivingLicenseInformationEntity.CityName);	
                Database.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.IssuedDate);	
                Database.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.ExpiryDate);	
                Database.AddInParameter(cmd, "@RenewDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.RenewDate);	
                Database.AddInParameter(cmd, "@IsDefaultLicense", DbType.Boolean, hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense);
                Database.AddInParameter(cmd, "@IssueAuthority", DbType.String, hREmployeeDrivingLicenseInformationEntity.IssueAuthority);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDrivingLicenseInformationEntity.Remarks);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeDrivingLicenseInformationID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@DrivingLicenseCategoryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID);
                db.AddInParameter(cmd, "@LicenseNumber", DbType.String, hREmployeeDrivingLicenseInformationEntity.LicenseNumber);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.CountryID);
                db.AddInParameter(cmd, "@CityName", DbType.String, hREmployeeDrivingLicenseInformationEntity.CityName);
                db.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.IssuedDate);
                db.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.ExpiryDate);
                db.AddInParameter(cmd, "@RenewDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.RenewDate);
                db.AddInParameter(cmd, "@IsDefaultLicense", DbType.Boolean, hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense);
                db.AddInParameter(cmd, "@IssueAuthority", DbType.String, hREmployeeDrivingLicenseInformationEntity.IssueAuthority);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDrivingLicenseInformationEntity.Remarks);

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

        IList<Int64> IHREmployeeDrivingLicenseInformationDataAccess.Add(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity in hREmployeeDrivingLicenseInformationEntityList)
            {
                returnCode = (this as IHREmployeeDrivingLicenseInformationDataAccess).Add(hREmployeeDrivingLicenseInformationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeDrivingLicenseInformationDataAccess.Update(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeDrivingLicenseInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeDrivingLicenseInformationEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeDrivingLicenseInformationID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeDrivingLicenseInformationID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeID);
                Database.AddInParameter(cmd, "@DrivingLicenseCategoryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID);
                Database.AddInParameter(cmd, "@LicenseNumber", DbType.String, hREmployeeDrivingLicenseInformationEntity.LicenseNumber);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.CountryID);
                Database.AddInParameter(cmd, "@CityName", DbType.String, hREmployeeDrivingLicenseInformationEntity.CityName);
                Database.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.IssuedDate);
                Database.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.ExpiryDate);
                Database.AddInParameter(cmd, "@RenewDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.RenewDate);
                Database.AddInParameter(cmd, "@IsDefaultLicense", DbType.Boolean, hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense);
                Database.AddInParameter(cmd, "@IssueAuthority", DbType.String, hREmployeeDrivingLicenseInformationEntity.IssueAuthority);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDrivingLicenseInformationEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeDrivingLicenseInformationID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeDrivingLicenseInformationID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.EmployeeID);
                db.AddInParameter(cmd, "@DrivingLicenseCategoryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.DrivingLicenseCategoryID);
                db.AddInParameter(cmd, "@LicenseNumber", DbType.String, hREmployeeDrivingLicenseInformationEntity.LicenseNumber);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, hREmployeeDrivingLicenseInformationEntity.CountryID);
                db.AddInParameter(cmd, "@CityName", DbType.String, hREmployeeDrivingLicenseInformationEntity.CityName);
                db.AddInParameter(cmd, "@IssuedDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.IssuedDate);
                db.AddInParameter(cmd, "@ExpiryDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.ExpiryDate);
                db.AddInParameter(cmd, "@RenewDate", DbType.DateTime, hREmployeeDrivingLicenseInformationEntity.RenewDate);
                db.AddInParameter(cmd, "@IsDefaultLicense", DbType.Boolean, hREmployeeDrivingLicenseInformationEntity.IsDefaultLicense);
                db.AddInParameter(cmd, "@IssueAuthority", DbType.String, hREmployeeDrivingLicenseInformationEntity.IssueAuthority);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeDrivingLicenseInformationEntity.Remarks);

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

        IList<Int64> IHREmployeeDrivingLicenseInformationDataAccess.Update(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity in hREmployeeDrivingLicenseInformationEntityList)
            {
                returnCode = (this as IHREmployeeDrivingLicenseInformationDataAccess).Update(hREmployeeDrivingLicenseInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeDrivingLicenseInformationDataAccess.Delete(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeDrivingLicenseInformationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeDrivingLicenseInformationEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

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
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeDrivingLicenseInformationEntity already exists. Please specify another HREmployeeDrivingLicenseInformationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeDrivingLicenseInformation_SET";

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

        IList<Int64> IHREmployeeDrivingLicenseInformationDataAccess.Delete(IList<HREmployeeDrivingLicenseInformationEntity> hREmployeeDrivingLicenseInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeDrivingLicenseInformationEntity hREmployeeDrivingLicenseInformationEntity in hREmployeeDrivingLicenseInformationEntityList)
            {
                returnCode = (this as IHREmployeeDrivingLicenseInformationDataAccess).Delete(hREmployeeDrivingLicenseInformationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeDrivingLicenseInformationEntity> IHREmployeeDrivingLicenseInformationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeDrivingLicenseInformation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeDrivingLicenseInformationEntity> list = CreateEntityBuilder<HREmployeeDrivingLicenseInformationEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeDrivingLicenseInformationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeDrivingLicenseInformation_GET";

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
