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
    internal sealed partial class HREmployeeFamilyInfoDataAccess : BaseDataAccess, IHREmployeeFamilyInfoDataAccess
    {
        #region Constructors

        public HREmployeeFamilyInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeFamilyInfoEntity> CreateEntityBuilder<HREmployeeFamilyInfoEntity>()
        {
            return (new HREmployeeFamilyInfoBuilder()) as IEntityBuilder<HREmployeeFamilyInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeFamilyInfoDataAccess.Add(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeFamilyInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeFamilyInfoEntity, option);
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

        private Int64 Add(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "HREmployeeFamilyInfoID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeFamilyInfoEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@FamilyRelationTypeID", DbType.Int64, hREmployeeFamilyInfoEntity.FamilyRelationTypeID);	
                Database.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeFamilyInfoEntity.FirstName);	
                Database.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeFamilyInfoEntity.MiddleName);	
                Database.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeFamilyInfoEntity.LastName);	
                Database.AddInParameter(cmd, "@Profession", DbType.String, hREmployeeFamilyInfoEntity.Profession);	
                Database.AddInParameter(cmd, "@IsDependent", DbType.Boolean, hREmployeeFamilyInfoEntity.IsDependent);	
                Database.AddInParameter(cmd, "@LastEducationAcquired", DbType.Int64, hREmployeeFamilyInfoEntity.LastEducationAcquired);	
                Database.AddInParameter(cmd, "@IsEmployed", DbType.Boolean, hREmployeeFamilyInfoEntity.IsEmployed);	
                Database.AddInParameter(cmd, "@Age", DbType.Decimal, hREmployeeFamilyInfoEntity.Age);	
                Database.AddInParameter(cmd, "@EmailAddress", DbType.String, hREmployeeFamilyInfoEntity.EmailAddress);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, hREmployeeFamilyInfoEntity.Phone);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "HREmployeeFamilyInfoID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeFamilyInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@FamilyRelationTypeID", DbType.Int64, hREmployeeFamilyInfoEntity.FamilyRelationTypeID);
                db.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeFamilyInfoEntity.FirstName);
                db.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeFamilyInfoEntity.MiddleName);
                db.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeFamilyInfoEntity.LastName);
                db.AddInParameter(cmd, "@Profession", DbType.String, hREmployeeFamilyInfoEntity.Profession);
                db.AddInParameter(cmd, "@IsDependent", DbType.Boolean, hREmployeeFamilyInfoEntity.IsDependent);
                db.AddInParameter(cmd, "@LastEducationAcquired", DbType.Int64, hREmployeeFamilyInfoEntity.LastEducationAcquired);
                db.AddInParameter(cmd, "@IsEmployed", DbType.Boolean, hREmployeeFamilyInfoEntity.IsEmployed);
                db.AddInParameter(cmd, "@Age", DbType.Decimal, hREmployeeFamilyInfoEntity.Age);
                db.AddInParameter(cmd, "@EmailAddress", DbType.String, hREmployeeFamilyInfoEntity.EmailAddress);
                db.AddInParameter(cmd, "@Phone", DbType.String, hREmployeeFamilyInfoEntity.Phone);

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

        IList<Int64> IHREmployeeFamilyInfoDataAccess.Add(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity in hREmployeeFamilyInfoEntityList)
            {
                returnCode = (this as IHREmployeeFamilyInfoDataAccess).Add(hREmployeeFamilyInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeFamilyInfoDataAccess.Update(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeFamilyInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeFamilyInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@HREmployeeFamilyInfoID", DbType.Int64, hREmployeeFamilyInfoEntity.HREmployeeFamilyInfoID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeFamilyInfoEntity.EmployeeID);
                Database.AddInParameter(cmd, "@FamilyRelationTypeID", DbType.Int64, hREmployeeFamilyInfoEntity.FamilyRelationTypeID);
                Database.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeFamilyInfoEntity.FirstName);
                Database.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeFamilyInfoEntity.MiddleName);
                Database.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeFamilyInfoEntity.LastName);
                Database.AddInParameter(cmd, "@Profession", DbType.String, hREmployeeFamilyInfoEntity.Profession);
                Database.AddInParameter(cmd, "@IsDependent", DbType.Boolean, hREmployeeFamilyInfoEntity.IsDependent);
                Database.AddInParameter(cmd, "@LastEducationAcquired", DbType.Int64, hREmployeeFamilyInfoEntity.LastEducationAcquired);
                Database.AddInParameter(cmd, "@IsEmployed", DbType.Boolean, hREmployeeFamilyInfoEntity.IsEmployed);
                Database.AddInParameter(cmd, "@Age", DbType.Decimal, hREmployeeFamilyInfoEntity.Age);
                Database.AddInParameter(cmd, "@EmailAddress", DbType.String, hREmployeeFamilyInfoEntity.EmailAddress);
                Database.AddInParameter(cmd, "@Phone", DbType.String, hREmployeeFamilyInfoEntity.Phone);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@HREmployeeFamilyInfoID", DbType.Int64, hREmployeeFamilyInfoEntity.HREmployeeFamilyInfoID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeFamilyInfoEntity.EmployeeID);
                db.AddInParameter(cmd, "@FamilyRelationTypeID", DbType.Int64, hREmployeeFamilyInfoEntity.FamilyRelationTypeID);
                db.AddInParameter(cmd, "@FirstName", DbType.String, hREmployeeFamilyInfoEntity.FirstName);
                db.AddInParameter(cmd, "@MiddleName", DbType.String, hREmployeeFamilyInfoEntity.MiddleName);
                db.AddInParameter(cmd, "@LastName", DbType.String, hREmployeeFamilyInfoEntity.LastName);
                db.AddInParameter(cmd, "@Profession", DbType.String, hREmployeeFamilyInfoEntity.Profession);
                db.AddInParameter(cmd, "@IsDependent", DbType.Boolean, hREmployeeFamilyInfoEntity.IsDependent);
                db.AddInParameter(cmd, "@LastEducationAcquired", DbType.Int64, hREmployeeFamilyInfoEntity.LastEducationAcquired);
                db.AddInParameter(cmd, "@IsEmployed", DbType.Boolean, hREmployeeFamilyInfoEntity.IsEmployed);
                db.AddInParameter(cmd, "@Age", DbType.Decimal, hREmployeeFamilyInfoEntity.Age);
                db.AddInParameter(cmd, "@EmailAddress", DbType.String, hREmployeeFamilyInfoEntity.EmailAddress);
                db.AddInParameter(cmd, "@Phone", DbType.String, hREmployeeFamilyInfoEntity.Phone);

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

        IList<Int64> IHREmployeeFamilyInfoDataAccess.Update(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity in hREmployeeFamilyInfoEntityList)
            {
                returnCode = (this as IHREmployeeFamilyInfoDataAccess).Update(hREmployeeFamilyInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeFamilyInfoDataAccess.Delete(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeFamilyInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeFamilyInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

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
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeFamilyInfoEntity already exists. Please specify another HREmployeeFamilyInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeFamilyInfo_SET";

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

        IList<Int64> IHREmployeeFamilyInfoDataAccess.Delete(IList<HREmployeeFamilyInfoEntity> hREmployeeFamilyInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeFamilyInfoEntity hREmployeeFamilyInfoEntity in hREmployeeFamilyInfoEntityList)
            {
                returnCode = (this as IHREmployeeFamilyInfoDataAccess).Delete(hREmployeeFamilyInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeFamilyInfoEntity> IHREmployeeFamilyInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeFamilyInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeFamilyInfoEntity> list = CreateEntityBuilder<HREmployeeFamilyInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeFamilyInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeFamilyInfo_GET";

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
