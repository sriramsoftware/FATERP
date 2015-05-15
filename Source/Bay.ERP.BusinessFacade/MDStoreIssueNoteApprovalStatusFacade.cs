// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 12:52:14




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
    public sealed partial class MDStoreIssueNoteApprovalStatusFacade : IMDStoreIssueNoteApprovalStatusFacade
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

        public MDStoreIssueNoteApprovalStatusFacade()
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

        ~MDStoreIssueNoteApprovalStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDStoreIssueNoteApprovalStatusFacade.Add(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Add(mDStoreIssueNoteApprovalStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDStoreIssueNoteApprovalStatusFacade.Update(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Update(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDStoreIssueNoteApprovalStatusFacade.Delete(MDStoreIssueNoteApprovalStatusEntity mDStoreIssueNoteApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Delete(mDStoreIssueNoteApprovalStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDStoreIssueNoteApprovalStatusFacade.Add(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Add(mDStoreIssueNoteApprovalStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDStoreIssueNoteApprovalStatusFacade.Update(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Update(mDStoreIssueNoteApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDStoreIssueNoteApprovalStatusFacade.Delete(IList<MDStoreIssueNoteApprovalStatusEntity> mDStoreIssueNoteApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().Delete(mDStoreIssueNoteApprovalStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDStoreIssueNoteApprovalStatusEntity> IMDStoreIssueNoteApprovalStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDStoreIssueNoteApprovalStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDStoreIssueNoteApprovalStatusEntity IMDStoreIssueNoteApprovalStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDStoreIssueNoteApprovalStatusEntity.FLD_NAME_StoreIssueNoteApprovalStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDStoreIssueNoteApprovalStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
