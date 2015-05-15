// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDApprovalRuleDesignationMapFacade : IMDApprovalRuleDesignationMapFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public MDApprovalRuleDesignationMapFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~MDApprovalRuleDesignationMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDApprovalRuleDesignationMapFacade.Add(MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Add(mDApprovalRuleDesignationMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDApprovalRuleDesignationMapFacade.Update(MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Update(mDApprovalRuleDesignationMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDApprovalRuleDesignationMapFacade.Delete(MDApprovalRuleDesignationMapEntity mDApprovalRuleDesignationMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Delete(mDApprovalRuleDesignationMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDApprovalRuleDesignationMapFacade.Add(IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Add(mDApprovalRuleDesignationMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDApprovalRuleDesignationMapFacade.Update(IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Update(mDApprovalRuleDesignationMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDApprovalRuleDesignationMapFacade.Delete(IList<MDApprovalRuleDesignationMapEntity> mDApprovalRuleDesignationMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().Delete(mDApprovalRuleDesignationMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDApprovalRuleDesignationMapEntity> IMDApprovalRuleDesignationMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDApprovalRuleDesignationMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDApprovalRuleDesignationMapEntity IMDApprovalRuleDesignationMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDApprovalRuleDesignationMapEntity.FLD_NAME_ApprovalRuleDesignationMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDApprovalRuleDesignationMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
