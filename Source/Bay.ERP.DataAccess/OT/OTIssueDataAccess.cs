// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Aug-2013, 04:20:37




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
    internal sealed partial class OTIssueDataAccess : BaseDataAccess, IOTIssueDataAccess
    {
        #region Constructors

        public OTIssueDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssueEntity> CreateEntityBuilder<OTIssueEntity>()
        {
            return (new OTIssueBuilder()) as IEntityBuilder<OTIssueEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IOTIssueDataAccess.Add(OTIssueEntity oTIssueEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(oTIssueEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(oTIssueEntity, option);
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

        private Int64 Add(OTIssueEntity oTIssueEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "IssueID");

                Database.AddInParameter(cmd, "@IssueIdentityCategoryID", DbType.Int64, oTIssueEntity.IssueIdentityCategoryID);	
                Database.AddInParameter(cmd, "@IssueCategoryID", DbType.Int64, oTIssueEntity.IssueCategoryID);	
                Database.AddInParameter(cmd, "@ParentIssueID", DbType.Int64, oTIssueEntity.ParentIssueID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTIssueEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Title", DbType.String, oTIssueEntity.Title);	
                Database.AddInParameter(cmd, "@Description", DbType.String, oTIssueEntity.Description);	
                Database.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, oTIssueEntity.IssuePriorityID);	
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, oTIssueEntity.CompletionPercentage);	
                Database.AddInParameter(cmd, "@IssueStatusID", DbType.Int64, oTIssueEntity.IssueStatusID);	
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTIssueEntity.CreatedByMemberID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTIssueEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, oTIssueEntity.Duration);	
                Database.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, oTIssueEntity.ExpectedStartDate);	
                Database.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, oTIssueEntity.ExpectedEndDate);	
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, oTIssueEntity.ActualStartDate);	
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, oTIssueEntity.ActualEndDate);	
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTIssueEntity.NotifyBeforeMin);	
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTIssueEntity.IsNotifyCompleted);	
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, oTIssueEntity.SupervisorEmployeeID);	
                Database.AddInParameter(cmd, "@AssignedToEmployeeID", DbType.Int64, oTIssueEntity.AssignedToEmployeeID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueEntity.Remarks);	
                Database.AddInParameter(cmd, "@ReferenceIssueID", DbType.Int64, oTIssueEntity.ReferenceIssueID);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTIssueEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@SupervisorAgreed", DbType.Boolean, oTIssueEntity.SupervisorAgreed);	
                Database.AddInParameter(cmd, "@ModifiedBySupervisorDateTime", DbType.DateTime, oTIssueEntity.ModifiedBySupervisorDateTime);	
                Database.AddInParameter(cmd, "@IP", DbType.String, oTIssueEntity.IP);
                Database.AddInParameter(cmd, "@DTLDuration", DbType.String, oTIssueEntity.DTLDuration);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, oTIssueEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, oTIssueEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, oTIssueEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitLocationID", DbType.Int64, oTIssueEntity.ProjectFloorUnitLocationID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(OTIssueEntity oTIssueEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "IssueID", db);

                db.AddInParameter(cmd, "@IssueIdentityCategoryID", DbType.Int64, oTIssueEntity.IssueIdentityCategoryID);
                db.AddInParameter(cmd, "@IssueCategoryID", DbType.Int64, oTIssueEntity.IssueCategoryID);
                db.AddInParameter(cmd, "@ParentIssueID", DbType.Int64, oTIssueEntity.ParentIssueID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTIssueEntity.ReferenceID);
                db.AddInParameter(cmd, "@Title", DbType.String, oTIssueEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, oTIssueEntity.Description);
                db.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, oTIssueEntity.IssuePriorityID);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, oTIssueEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@IssueStatusID", DbType.Int64, oTIssueEntity.IssueStatusID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTIssueEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTIssueEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, oTIssueEntity.Duration);
                db.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, oTIssueEntity.ExpectedStartDate);
                db.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, oTIssueEntity.ExpectedEndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, oTIssueEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, oTIssueEntity.ActualEndDate);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTIssueEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTIssueEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, oTIssueEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@AssignedToEmployeeID", DbType.Int64, oTIssueEntity.AssignedToEmployeeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueEntity.Remarks);
                db.AddInParameter(cmd, "@ReferenceIssueID", DbType.Int64, oTIssueEntity.ReferenceIssueID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTIssueEntity.IsRemoved);
                db.AddInParameter(cmd, "@SupervisorAgreed", DbType.Boolean, oTIssueEntity.SupervisorAgreed);
                db.AddInParameter(cmd, "@ModifiedBySupervisorDateTime", DbType.DateTime, oTIssueEntity.ModifiedBySupervisorDateTime);
                db.AddInParameter(cmd, "@IP", DbType.String, oTIssueEntity.IP);
                db.AddInParameter(cmd, "@DTLDuration", DbType.Time, oTIssueEntity.DTLDuration);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, oTIssueEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, oTIssueEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, oTIssueEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectFloorUnitLocationID", DbType.Int64, oTIssueEntity.ProjectFloorUnitLocationID);

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

        IList<Int64> IOTIssueDataAccess.Add(IList<OTIssueEntity> oTIssueEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (OTIssueEntity oTIssueEntity in oTIssueEntityList)
            {
                returnCode = (this as IOTIssueDataAccess).Add(oTIssueEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IOTIssueDataAccess.Update(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(oTIssueEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(oTIssueEntity, filterExpression, option);
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

        private Int64 Update(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueEntity.IssueID);
                Database.AddInParameter(cmd, "@IssueIdentityCategoryID", DbType.Int64, oTIssueEntity.IssueIdentityCategoryID);
                Database.AddInParameter(cmd, "@IssueCategoryID", DbType.Int64, oTIssueEntity.IssueCategoryID);
                Database.AddInParameter(cmd, "@ParentIssueID", DbType.Int64, oTIssueEntity.ParentIssueID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTIssueEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Title", DbType.String, oTIssueEntity.Title);
                Database.AddInParameter(cmd, "@Description", DbType.String, oTIssueEntity.Description);
                Database.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, oTIssueEntity.IssuePriorityID);
                Database.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, oTIssueEntity.CompletionPercentage);
                Database.AddInParameter(cmd, "@IssueStatusID", DbType.Int64, oTIssueEntity.IssueStatusID);
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTIssueEntity.CreatedByMemberID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTIssueEntity.CreateDate);
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, oTIssueEntity.Duration);
                Database.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, oTIssueEntity.ExpectedStartDate);
                Database.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, oTIssueEntity.ExpectedEndDate);
                Database.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, oTIssueEntity.ActualStartDate);
                Database.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, oTIssueEntity.ActualEndDate);
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTIssueEntity.NotifyBeforeMin);
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTIssueEntity.IsNotifyCompleted);
                Database.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, oTIssueEntity.SupervisorEmployeeID);
                Database.AddInParameter(cmd, "@AssignedToEmployeeID", DbType.Int64, oTIssueEntity.AssignedToEmployeeID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueEntity.Remarks);
                Database.AddInParameter(cmd, "@ReferenceIssueID", DbType.Int64, oTIssueEntity.ReferenceIssueID);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTIssueEntity.IsRemoved);
                Database.AddInParameter(cmd, "@SupervisorAgreed", DbType.Boolean, oTIssueEntity.SupervisorAgreed);
                Database.AddInParameter(cmd, "@ModifiedBySupervisorDateTime", DbType.DateTime, oTIssueEntity.ModifiedBySupervisorDateTime);
                Database.AddInParameter(cmd, "@IP", DbType.String, oTIssueEntity.IP);
                Database.AddInParameter(cmd, "@DTLDuration", DbType.String, oTIssueEntity.DTLDuration);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, oTIssueEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, oTIssueEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, oTIssueEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitLocationID", DbType.Int64, oTIssueEntity.ProjectFloorUnitLocationID);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueEntity.IssueID);
                db.AddInParameter(cmd, "@IssueIdentityCategoryID", DbType.Int64, oTIssueEntity.IssueIdentityCategoryID);
                db.AddInParameter(cmd, "@IssueCategoryID", DbType.Int64, oTIssueEntity.IssueCategoryID);
                db.AddInParameter(cmd, "@ParentIssueID", DbType.Int64, oTIssueEntity.ParentIssueID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTIssueEntity.ReferenceID);
                db.AddInParameter(cmd, "@Title", DbType.String, oTIssueEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, oTIssueEntity.Description);
                db.AddInParameter(cmd, "@IssuePriorityID", DbType.Int64, oTIssueEntity.IssuePriorityID);
                db.AddInParameter(cmd, "@CompletionPercentage", DbType.Decimal, oTIssueEntity.CompletionPercentage);
                db.AddInParameter(cmd, "@IssueStatusID", DbType.Int64, oTIssueEntity.IssueStatusID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTIssueEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTIssueEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, oTIssueEntity.Duration);
                db.AddInParameter(cmd, "@ExpectedStartDate", DbType.DateTime, oTIssueEntity.ExpectedStartDate);
                db.AddInParameter(cmd, "@ExpectedEndDate", DbType.DateTime, oTIssueEntity.ExpectedEndDate);
                db.AddInParameter(cmd, "@ActualStartDate", DbType.DateTime, oTIssueEntity.ActualStartDate);
                db.AddInParameter(cmd, "@ActualEndDate", DbType.DateTime, oTIssueEntity.ActualEndDate);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTIssueEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTIssueEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@SupervisorEmployeeID", DbType.Int64, oTIssueEntity.SupervisorEmployeeID);
                db.AddInParameter(cmd, "@AssignedToEmployeeID", DbType.Int64, oTIssueEntity.AssignedToEmployeeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueEntity.Remarks);
                db.AddInParameter(cmd, "@ReferenceIssueID", DbType.Int64, oTIssueEntity.ReferenceIssueID);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTIssueEntity.IsRemoved);
                db.AddInParameter(cmd, "@SupervisorAgreed", DbType.Boolean, oTIssueEntity.SupervisorAgreed);
                db.AddInParameter(cmd, "@ModifiedBySupervisorDateTime", DbType.DateTime, oTIssueEntity.ModifiedBySupervisorDateTime);
                db.AddInParameter(cmd, "@IP", DbType.String, oTIssueEntity.IP);
                db.AddInParameter(cmd, "@DTLDuration", DbType.String, oTIssueEntity.DTLDuration);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, oTIssueEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, oTIssueEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, oTIssueEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@ProjectFloorUnitLocationID", DbType.Int64, oTIssueEntity.ProjectFloorUnitLocationID);


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

        IList<Int64> IOTIssueDataAccess.Update(IList<OTIssueEntity> oTIssueEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (OTIssueEntity oTIssueEntity in oTIssueEntityList)
            {
                returnCode = (this as IOTIssueDataAccess).Update(oTIssueEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IOTIssueDataAccess.Delete(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(oTIssueEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(oTIssueEntity, filterExpression, option);
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

        private Int64 Delete(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

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
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueEntity already exists. Please specify another OTIssueEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(OTIssueEntity oTIssueEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssue_SET";

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

        IList<Int64> IOTIssueDataAccess.Delete(IList<OTIssueEntity> oTIssueEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (OTIssueEntity oTIssueEntity in oTIssueEntityList)
            {
                returnCode = (this as IOTIssueDataAccess).Delete(oTIssueEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<OTIssueEntity> IOTIssueDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssue_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssueEntity> list = CreateEntityBuilder<OTIssueEntity>().BuildEntities(reader);

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

        DataTable IOTIssueDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssue_GET";

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
