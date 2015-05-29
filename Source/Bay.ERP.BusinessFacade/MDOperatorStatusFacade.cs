// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:41:19




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
    public sealed partial class MDOperatorStatusFacade : IMDOperatorStatusFacade
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

        public MDOperatorStatusFacade()
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

        ~MDOperatorStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDOperatorStatusFacade.Add(MDOperatorStatusEntity mDOperatorStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Add(mDOperatorStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDOperatorStatusFacade.Update(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Update(mDOperatorStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDOperatorStatusFacade.Delete(MDOperatorStatusEntity mDOperatorStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Delete(mDOperatorStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDOperatorStatusFacade.Add(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Add(mDOperatorStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDOperatorStatusFacade.Update(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Update(mDOperatorStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDOperatorStatusFacade.Delete(IList<MDOperatorStatusEntity> mDOperatorStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().Delete(mDOperatorStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDOperatorStatusEntity> IMDOperatorStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDOperatorStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDOperatorStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDOperatorStatusEntity IMDOperatorStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDOperatorStatusEntity.FLD_NAME_OperatorStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDOperatorStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
