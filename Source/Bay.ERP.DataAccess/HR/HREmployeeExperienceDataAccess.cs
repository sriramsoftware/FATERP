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
    internal sealed partial class HREmployeeExperienceDataAccess : BaseDataAccess, IHREmployeeExperienceDataAccess
    {
        #region Constructors

        public HREmployeeExperienceDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeExperienceEntity> CreateEntityBuilder<HREmployeeExperienceEntity>()
        {
            return (new HREmployeeExperienceBuilder()) as IEntityBuilder<HREmployeeExperienceEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeExperienceDataAccess.Add(HREmployeeExperienceEntity hREmployeeExperienceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeExperienceEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeExperienceEntity, option);
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

        private Int64 Add(HREmployeeExperienceEntity hREmployeeExperienceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeExperienceID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@CompanyCountryID", DbType.Int64, hREmployeeExperienceEntity.CompanyCountryID);	
                Database.AddInParameter(cmd, "@CompanyName", DbType.String, hREmployeeExperienceEntity.CompanyName);	
                Database.AddInParameter(cmd, "@Address", DbType.String, hREmployeeExperienceEntity.Address);	
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeJobTypeID);	
                Database.AddInParameter(cmd, "@JobEndDate", DbType.DateTime, hREmployeeExperienceEntity.JobEndDate);	
                Database.AddInParameter(cmd, "@JobStartDate", DbType.DateTime, hREmployeeExperienceEntity.JobStartDate);	
                Database.AddInParameter(cmd, "@ContactNo", DbType.String, hREmployeeExperienceEntity.ContactNo);	
                Database.AddInParameter(cmd, "@WebLink", DbType.String, hREmployeeExperienceEntity.WebLink);	
                Database.AddInParameter(cmd, "@IsLastCompany", DbType.Boolean, hREmployeeExperienceEntity.IsLastCompany);
                Database.AddInParameter(cmd, "@Designation", DbType.String, hREmployeeExperienceEntity.Designation);
                Database.AddInParameter(cmd, "@Responsibility", DbType.String, hREmployeeExperienceEntity.Responsibility);
                Database.AddInParameter(cmd, "@SupervisorName", DbType.String, hREmployeeExperienceEntity.SupervisorName);
                Database.AddInParameter(cmd, "@SalaryOrBenefits", DbType.String, hREmployeeExperienceEntity.SalaryOrBenefits);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeExperienceEntity hREmployeeExperienceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeExperienceID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeID);
                db.AddInParameter(cmd, "@CompanyCountryID", DbType.Int64, hREmployeeExperienceEntity.CompanyCountryID);
                db.AddInParameter(cmd, "@CompanyName", DbType.String, hREmployeeExperienceEntity.CompanyName);
                db.AddInParameter(cmd, "@Address", DbType.String, hREmployeeExperienceEntity.Address);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@JobEndDate", DbType.DateTime, hREmployeeExperienceEntity.JobEndDate);
                db.AddInParameter(cmd, "@JobStartDate", DbType.DateTime, hREmployeeExperienceEntity.JobStartDate);
                db.AddInParameter(cmd, "@ContactNo", DbType.String, hREmployeeExperienceEntity.ContactNo);
                db.AddInParameter(cmd, "@WebLink", DbType.String, hREmployeeExperienceEntity.WebLink);
                db.AddInParameter(cmd, "@IsLastCompany", DbType.Boolean, hREmployeeExperienceEntity.IsLastCompany);
                db.AddInParameter(cmd, "@Designation", DbType.String, hREmployeeExperienceEntity.Designation);
                db.AddInParameter(cmd, "@Responsibility", DbType.String, hREmployeeExperienceEntity.Responsibility);
                db.AddInParameter(cmd, "@SupervisorName", DbType.String, hREmployeeExperienceEntity.SupervisorName);
                db.AddInParameter(cmd, "@SalaryOrBenefits", DbType.String, hREmployeeExperienceEntity.SalaryOrBenefits);

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

        IList<Int64> IHREmployeeExperienceDataAccess.Add(IList<HREmployeeExperienceEntity> hREmployeeExperienceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeExperienceEntity hREmployeeExperienceEntity in hREmployeeExperienceEntityList)
            {
                returnCode = (this as IHREmployeeExperienceDataAccess).Add(hREmployeeExperienceEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeExperienceDataAccess.Update(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeExperienceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeExperienceEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeExperienceID", DbType.Int64, hREmployeeExperienceEntity.EmployeeExperienceID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeID);
                Database.AddInParameter(cmd, "@CompanyCountryID", DbType.Int64, hREmployeeExperienceEntity.CompanyCountryID);
                Database.AddInParameter(cmd, "@CompanyName", DbType.String, hREmployeeExperienceEntity.CompanyName);
                Database.AddInParameter(cmd, "@Address", DbType.String, hREmployeeExperienceEntity.Address);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@JobEndDate", DbType.DateTime, hREmployeeExperienceEntity.JobEndDate);
                Database.AddInParameter(cmd, "@JobStartDate", DbType.DateTime, hREmployeeExperienceEntity.JobStartDate);
                Database.AddInParameter(cmd, "@ContactNo", DbType.String, hREmployeeExperienceEntity.ContactNo);
                Database.AddInParameter(cmd, "@WebLink", DbType.String, hREmployeeExperienceEntity.WebLink);
                Database.AddInParameter(cmd, "@IsLastCompany", DbType.Boolean, hREmployeeExperienceEntity.IsLastCompany);
                Database.AddInParameter(cmd, "@Designation", DbType.String, hREmployeeExperienceEntity.Designation);
                Database.AddInParameter(cmd, "@Responsibility", DbType.String, hREmployeeExperienceEntity.Responsibility);
                Database.AddInParameter(cmd, "@SupervisorName", DbType.String, hREmployeeExperienceEntity.SupervisorName);
                Database.AddInParameter(cmd, "@SalaryOrBenefits", DbType.String, hREmployeeExperienceEntity.SalaryOrBenefits);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeExperienceID", DbType.Int64, hREmployeeExperienceEntity.EmployeeExperienceID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeID);
                db.AddInParameter(cmd, "@CompanyCountryID", DbType.Int64, hREmployeeExperienceEntity.CompanyCountryID);
                db.AddInParameter(cmd, "@CompanyName", DbType.String, hREmployeeExperienceEntity.CompanyName);
                db.AddInParameter(cmd, "@Address", DbType.String, hREmployeeExperienceEntity.Address);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeExperienceEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@JobEndDate", DbType.DateTime, hREmployeeExperienceEntity.JobEndDate);
                db.AddInParameter(cmd, "@JobStartDate", DbType.DateTime, hREmployeeExperienceEntity.JobStartDate);
                db.AddInParameter(cmd, "@ContactNo", DbType.String, hREmployeeExperienceEntity.ContactNo);
                db.AddInParameter(cmd, "@WebLink", DbType.String, hREmployeeExperienceEntity.WebLink);
                db.AddInParameter(cmd, "@IsLastCompany", DbType.Boolean, hREmployeeExperienceEntity.IsLastCompany);
                db.AddInParameter(cmd, "@Designation", DbType.String, hREmployeeExperienceEntity.Designation);
                db.AddInParameter(cmd, "@Responsibility", DbType.String, hREmployeeExperienceEntity.Responsibility);
                db.AddInParameter(cmd, "@SupervisorName", DbType.String, hREmployeeExperienceEntity.SupervisorName);
                db.AddInParameter(cmd, "@SalaryOrBenefits", DbType.String, hREmployeeExperienceEntity.SalaryOrBenefits);

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

        IList<Int64> IHREmployeeExperienceDataAccess.Update(IList<HREmployeeExperienceEntity> hREmployeeExperienceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeExperienceEntity hREmployeeExperienceEntity in hREmployeeExperienceEntityList)
            {
                returnCode = (this as IHREmployeeExperienceDataAccess).Update(hREmployeeExperienceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeExperienceDataAccess.Delete(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeExperienceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeExperienceEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

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
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeExperienceEntity already exists. Please specify another HREmployeeExperienceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeExperienceEntity hREmployeeExperienceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeExperience_SET";

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

        IList<Int64> IHREmployeeExperienceDataAccess.Delete(IList<HREmployeeExperienceEntity> hREmployeeExperienceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeExperienceEntity hREmployeeExperienceEntity in hREmployeeExperienceEntityList)
            {
                returnCode = (this as IHREmployeeExperienceDataAccess).Delete(hREmployeeExperienceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeExperienceEntity> IHREmployeeExperienceDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeExperience_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeExperienceEntity> list = CreateEntityBuilder<HREmployeeExperienceEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeExperienceDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeExperience_GET";

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
