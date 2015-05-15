// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    internal sealed partial class HREmployeeMonthlyTimeSheetSummaryDataAccess : BaseDataAccess, IHREmployeeMonthlyTimeSheetSummaryDataAccess
    {
        #region Constructors

        public HREmployeeMonthlyTimeSheetSummaryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity> CreateEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>()
        {
            return (new HREmployeeMonthlyTimeSheetSummaryBuilder()) as IEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeMonthlyTimeSheetSummaryDataAccess.Add(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeMonthlyTimeSheetSummaryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeMonthlyTimeSheetSummaryEntity, option);
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

        private Int64 Add(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeMonthlyTimeSheetID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID);	
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID);	
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@OnJob", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OnJob);	
                Database.AddInParameter(cmd, "@Holiday", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Holiday);	
                Database.AddInParameter(cmd, "@LCASUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL);	
                Database.AddInParameter(cmd, "@LMEDICAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL);	
                Database.AddInParameter(cmd, "@EARNLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE);	
                Database.AddInParameter(cmd, "@LWP", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LWP);	
                Database.AddInParameter(cmd, "@ACTUALWORKDAYS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS);	
                Database.AddInParameter(cmd, "@REMARKS", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS);	
                Database.AddInParameter(cmd, "@NUMBEROFMEALS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS);	
                Database.AddInParameter(cmd, "@PROJECTACTUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL);	
                Database.AddInParameter(cmd, "@OTHERLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE);	
                Database.AddInParameter(cmd, "@Field1", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Field1);	
                Database.AddInParameter(cmd, "@Field11", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field11);	
                Database.AddInParameter(cmd, "@Field12", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field12);	
                Database.AddInParameter(cmd, "@Field13", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field13);	
                Database.AddInParameter(cmd, "@Field14", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field14);	
                Database.AddInParameter(cmd, "@Field15", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field15);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeMonthlyTimeSheetID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID);
                db.AddInParameter(cmd, "@OnJob", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OnJob);
                db.AddInParameter(cmd, "@Holiday", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Holiday);
                db.AddInParameter(cmd, "@LCASUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL);
                db.AddInParameter(cmd, "@LMEDICAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL);
                db.AddInParameter(cmd, "@EARNLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE);
                db.AddInParameter(cmd, "@LWP", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LWP);
                db.AddInParameter(cmd, "@ACTUALWORKDAYS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS);
                db.AddInParameter(cmd, "@REMARKS", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS);
                db.AddInParameter(cmd, "@NUMBEROFMEALS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS);
                db.AddInParameter(cmd, "@PROJECTACTUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL);
                db.AddInParameter(cmd, "@OTHERLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE);
                db.AddInParameter(cmd, "@Field1", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Field1);
                db.AddInParameter(cmd, "@Field11", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field11);
                db.AddInParameter(cmd, "@Field12", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field12);
                db.AddInParameter(cmd, "@Field13", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field13);
                db.AddInParameter(cmd, "@Field14", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field14);
                db.AddInParameter(cmd, "@Field15", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field15);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID);

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

        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryDataAccess.Add(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity in hREmployeeMonthlyTimeSheetSummaryEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetSummaryDataAccess).Add(hREmployeeMonthlyTimeSheetSummaryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeMonthlyTimeSheetSummaryDataAccess.Update(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeMonthlyTimeSheetID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeMonthlyTimeSheetID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@OnJob", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OnJob);
                Database.AddInParameter(cmd, "@Holiday", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Holiday);
                Database.AddInParameter(cmd, "@LCASUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL);
                Database.AddInParameter(cmd, "@LMEDICAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL);
                Database.AddInParameter(cmd, "@EARNLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE);
                Database.AddInParameter(cmd, "@LWP", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LWP);
                Database.AddInParameter(cmd, "@ACTUALWORKDAYS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS);
                Database.AddInParameter(cmd, "@REMARKS", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS);
                Database.AddInParameter(cmd, "@NUMBEROFMEALS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS);
                Database.AddInParameter(cmd, "@PROJECTACTUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL);
                Database.AddInParameter(cmd, "@OTHERLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE);
                Database.AddInParameter(cmd, "@Field1", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Field1);
                Database.AddInParameter(cmd, "@Field11", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field11);
                Database.AddInParameter(cmd, "@Field12", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field12);
                Database.AddInParameter(cmd, "@Field13", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field13);
                Database.AddInParameter(cmd, "@Field14", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field14);
                Database.AddInParameter(cmd, "@Field15", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field15);
                Database.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeMonthlyTimeSheetID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeMonthlyTimeSheetID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeID);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hREmployeeMonthlyTimeSheetSummaryEntity.SalaryLevel);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.SalarySessionID);
                db.AddInParameter(cmd, "@OnJob", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OnJob);
                db.AddInParameter(cmd, "@Holiday", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Holiday);
                db.AddInParameter(cmd, "@LCASUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LCASUAL);
                db.AddInParameter(cmd, "@LMEDICAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LMEDICAL);
                db.AddInParameter(cmd, "@EARNLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.EARNLEAVE);
                db.AddInParameter(cmd, "@LWP", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.LWP);
                db.AddInParameter(cmd, "@ACTUALWORKDAYS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.ACTUALWORKDAYS);
                db.AddInParameter(cmd, "@REMARKS", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.REMARKS);
                db.AddInParameter(cmd, "@NUMBEROFMEALS", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.NUMBEROFMEALS);
                db.AddInParameter(cmd, "@PROJECTACTUAL", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.PROJECTACTUAL);
                db.AddInParameter(cmd, "@OTHERLEAVE", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.OTHERLEAVE);
                db.AddInParameter(cmd, "@Field1", DbType.Decimal, hREmployeeMonthlyTimeSheetSummaryEntity.Field1);
                db.AddInParameter(cmd, "@Field11", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field11);
                db.AddInParameter(cmd, "@Field12", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field12);
                db.AddInParameter(cmd, "@Field13", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field13);
                db.AddInParameter(cmd, "@Field14", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field14);
                db.AddInParameter(cmd, "@Field15", DbType.String, hREmployeeMonthlyTimeSheetSummaryEntity.Field15);
                db.AddInParameter(cmd, "@DepartmentID", DbType.Int64, hREmployeeMonthlyTimeSheetSummaryEntity.DepartmentID);

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

        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryDataAccess.Update(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity in hREmployeeMonthlyTimeSheetSummaryEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetSummaryDataAccess).Update(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeMonthlyTimeSheetSummaryDataAccess.Delete(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

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
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeMonthlyTimeSheetSummaryEntity already exists. Please specify another HREmployeeMonthlyTimeSheetSummaryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_SET";

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

        IList<Int64> IHREmployeeMonthlyTimeSheetSummaryDataAccess.Delete(IList<HREmployeeMonthlyTimeSheetSummaryEntity> hREmployeeMonthlyTimeSheetSummaryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeMonthlyTimeSheetSummaryEntity hREmployeeMonthlyTimeSheetSummaryEntity in hREmployeeMonthlyTimeSheetSummaryEntityList)
            {
                returnCode = (this as IHREmployeeMonthlyTimeSheetSummaryDataAccess).Delete(hREmployeeMonthlyTimeSheetSummaryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeMonthlyTimeSheetSummaryEntity> IHREmployeeMonthlyTimeSheetSummaryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeMonthlyTimeSheetSummaryEntity> list = CreateEntityBuilder<HREmployeeMonthlyTimeSheetSummaryEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeMonthlyTimeSheetSummaryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeMonthlyTimeSheetSummary_GET";

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