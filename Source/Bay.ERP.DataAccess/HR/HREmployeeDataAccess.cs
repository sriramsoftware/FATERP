// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Sep-2013, 04:18:32




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
    internal sealed partial class HREmployeeDataAccess : BaseDataAccess, IHREmployeeDataAccess
    {
        #region Constructors

        public HREmployeeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeEntity> CreateEntityBuilder<HREmployeeEntity>()
        {
            return (new HREmployeeBuilder()) as IEntityBuilder<HREmployeeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeDataAccess.Add(HREmployeeEntity hREmployeeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeEntity, option);
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

        private Int64 Add(HREmployeeEntity hREmployeeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeID");

                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, hREmployeeEntity.MemberID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeEntity.ProjectID);	
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeEntity.DepartmentID);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeEntity.DesignationID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeEntity.EmployeeJobTypeID);	
                Database.AddInParameter(cmd, "@ConfirmDate", DbType.DateTime, hREmployeeEntity.ConfirmDate);	
                Database.AddInParameter(cmd, "@JoinDate", DbType.DateTime, hREmployeeEntity.JoinDate);	
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, hREmployeeEntity.DOB);	
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeEntity.SalaryLevel);	
                Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeEntity.BloodGroupID);	
                Database.AddInParameter(cmd, "@PrimaryEmail", DbType.String, hREmployeeEntity.PrimaryEmail);	
                Database.AddInParameter(cmd, "@SecondaryEmail", DbType.String, hREmployeeEntity.SecondaryEmail);	
                Database.AddInParameter(cmd, "@Initials", DbType.String, hREmployeeEntity.Initials);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeEntity.IsRemoved);
                Database.AddInParameter(cmd, "@EmploymentStatusID", DbType.Int64, hREmployeeEntity.EmploymentStatusID);
                Database.AddInParameter(cmd, "@DiscontinuedDate", DbType.DateTime, hREmployeeEntity.DiscontinuedDate);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeEntity hREmployeeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeID", db);

                db.AddInParameter(cmd, "@MemberID", DbType.Int64, hREmployeeEntity.MemberID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@ConfirmDate", DbType.DateTime, hREmployeeEntity.ConfirmDate);
                db.AddInParameter(cmd, "@JoinDate", DbType.DateTime, hREmployeeEntity.JoinDate);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, hREmployeeEntity.DOB);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeEntity.SalaryLevel);
                db.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeEntity.BloodGroupID);
                db.AddInParameter(cmd, "@PrimaryEmail", DbType.String, hREmployeeEntity.PrimaryEmail);
                db.AddInParameter(cmd, "@SecondaryEmail", DbType.String, hREmployeeEntity.SecondaryEmail);
                db.AddInParameter(cmd, "@Initials", DbType.String, hREmployeeEntity.Initials);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeEntity.IsRemoved);
                db.AddInParameter(cmd, "@EmploymentStatusID", DbType.Int64, hREmployeeEntity.EmploymentStatusID);
                db.AddInParameter(cmd, "@DiscontinuedDate", DbType.DateTime, hREmployeeEntity.DiscontinuedDate);

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

        IList<Int64> IHREmployeeDataAccess.Add(IList<HREmployeeEntity> hREmployeeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeEntity hREmployeeEntity in hREmployeeEntityList)
            {
                returnCode = (this as IHREmployeeDataAccess).Add(hREmployeeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeDataAccess.Update(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEntity.EmployeeID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, hREmployeeEntity.MemberID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeEntity.ProjectID);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeEntity.DepartmentID);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeEntity.DesignationID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@ConfirmDate", DbType.DateTime, hREmployeeEntity.ConfirmDate);
                Database.AddInParameter(cmd, "@JoinDate", DbType.DateTime, hREmployeeEntity.JoinDate);
                Database.AddInParameter(cmd, "@DOB", DbType.DateTime, hREmployeeEntity.DOB);
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeEntity.SalaryLevel);
                Database.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeEntity.BloodGroupID);
                Database.AddInParameter(cmd, "@PrimaryEmail", DbType.String, hREmployeeEntity.PrimaryEmail);
                Database.AddInParameter(cmd, "@SecondaryEmail", DbType.String, hREmployeeEntity.SecondaryEmail);
                Database.AddInParameter(cmd, "@Initials", DbType.String, hREmployeeEntity.Initials);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeEntity.IsRemoved);
                Database.AddInParameter(cmd, "@EmploymentStatusID", DbType.Int64, hREmployeeEntity.EmploymentStatusID);
                Database.AddInParameter(cmd, "@DiscontinuedDate", DbType.DateTime, hREmployeeEntity.DiscontinuedDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeEntity.EmployeeID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, hREmployeeEntity.MemberID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, hREmployeeEntity.ProjectID);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeEntity.DepartmentID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hREmployeeEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@ConfirmDate", DbType.DateTime, hREmployeeEntity.ConfirmDate);
                db.AddInParameter(cmd, "@JoinDate", DbType.DateTime, hREmployeeEntity.JoinDate);
                db.AddInParameter(cmd, "@DOB", DbType.DateTime, hREmployeeEntity.DOB);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeEntity.SalaryLevel);
                db.AddInParameter(cmd, "@BloodGroupID", DbType.Int64, hREmployeeEntity.BloodGroupID);
                db.AddInParameter(cmd, "@PrimaryEmail", DbType.String, hREmployeeEntity.PrimaryEmail);
                db.AddInParameter(cmd, "@SecondaryEmail", DbType.String, hREmployeeEntity.SecondaryEmail);
                db.AddInParameter(cmd, "@Initials", DbType.String, hREmployeeEntity.Initials);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hREmployeeEntity.IsRemoved);
                db.AddInParameter(cmd, "@EmploymentStatusID", DbType.Int64, hREmployeeEntity.EmploymentStatusID);
	            db.AddInParameter(cmd, "@DiscontinuedDate", DbType.DateTime, hREmployeeEntity.DiscontinuedDate);

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

        IList<Int64> IHREmployeeDataAccess.Update(IList<HREmployeeEntity> hREmployeeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeEntity hREmployeeEntity in hREmployeeEntityList)
            {
                returnCode = (this as IHREmployeeDataAccess).Update(hREmployeeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeDataAccess.Delete(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

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
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeEntity already exists. Please specify another HREmployeeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeEntity hREmployeeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployee_SET";

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

        IList<Int64> IHREmployeeDataAccess.Delete(IList<HREmployeeEntity> hREmployeeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeEntity hREmployeeEntity in hREmployeeEntityList)
            {
                returnCode = (this as IHREmployeeDataAccess).Delete(hREmployeeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeEntity> IHREmployeeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployee_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeEntity> list = CreateEntityBuilder<HREmployeeEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployee_GET";

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
