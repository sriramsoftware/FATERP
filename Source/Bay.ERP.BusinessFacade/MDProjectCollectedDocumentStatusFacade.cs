// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 01:41:28




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
    public sealed partial class MDProjectCollectedDocumentStatusFacade : IMDProjectCollectedDocumentStatusFacade
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

        public MDProjectCollectedDocumentStatusFacade()
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

        ~MDProjectCollectedDocumentStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDProjectCollectedDocumentStatusFacade.Add(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Add(mDProjectCollectedDocumentStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectCollectedDocumentStatusFacade.Update(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Update(mDProjectCollectedDocumentStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectCollectedDocumentStatusFacade.Delete(MDProjectCollectedDocumentStatusEntity mDProjectCollectedDocumentStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Delete(mDProjectCollectedDocumentStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDProjectCollectedDocumentStatusFacade.Add(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Add(mDProjectCollectedDocumentStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectCollectedDocumentStatusFacade.Update(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Update(mDProjectCollectedDocumentStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectCollectedDocumentStatusFacade.Delete(IList<MDProjectCollectedDocumentStatusEntity> mDProjectCollectedDocumentStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().Delete(mDProjectCollectedDocumentStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDProjectCollectedDocumentStatusEntity> IMDProjectCollectedDocumentStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDProjectCollectedDocumentStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDProjectCollectedDocumentStatusEntity IMDProjectCollectedDocumentStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectCollectedDocumentStatusEntity.FLD_NAME_ProjectCollectedDocumentStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDProjectCollectedDocumentStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
