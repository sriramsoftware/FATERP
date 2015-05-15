// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDLeaveApplicationApplicationStatusFacade : IMDLeaveApplicationApplicationStatusFacade
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

        public MDLeaveApplicationApplicationStatusFacade()
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

        ~MDLeaveApplicationApplicationStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDLeaveApplicationApplicationStatusFacade.Add(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Add(mDLeaveApplicationApplicationStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDLeaveApplicationApplicationStatusFacade.Update(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Update(mDLeaveApplicationApplicationStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDLeaveApplicationApplicationStatusFacade.Delete(MDLeaveApplicationApplicationStatusEntity mDLeaveApplicationApplicationStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Delete(mDLeaveApplicationApplicationStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDLeaveApplicationApplicationStatusFacade.Add(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Add(mDLeaveApplicationApplicationStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDLeaveApplicationApplicationStatusFacade.Update(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Update(mDLeaveApplicationApplicationStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDLeaveApplicationApplicationStatusFacade.Delete(IList<MDLeaveApplicationApplicationStatusEntity> mDLeaveApplicationApplicationStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().Delete(mDLeaveApplicationApplicationStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDLeaveApplicationApplicationStatusEntity> IMDLeaveApplicationApplicationStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDLeaveApplicationApplicationStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDLeaveApplicationApplicationStatusEntity IMDLeaveApplicationApplicationStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDLeaveApplicationApplicationStatusEntity.FLD_NAME_LeaveApplicationApplicationStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDLeaveApplicationApplicationStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
