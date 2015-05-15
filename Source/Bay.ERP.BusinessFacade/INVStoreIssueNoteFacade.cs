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
    public sealed partial class INVStoreIssueNoteFacade : IINVStoreIssueNoteFacade
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

        public INVStoreIssueNoteFacade()
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

        ~INVStoreIssueNoteFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IINVStoreIssueNoteFacade.Add(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Add(iNVStoreIssueNoteEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IINVStoreIssueNoteFacade.Update(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Update(iNVStoreIssueNoteEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IINVStoreIssueNoteFacade.Delete(INVStoreIssueNoteEntity iNVStoreIssueNoteEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Delete(iNVStoreIssueNoteEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteFacade.Add(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Add(iNVStoreIssueNoteEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteFacade.Update(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Update(iNVStoreIssueNoteEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteFacade.Delete(IList<INVStoreIssueNoteEntity> iNVStoreIssueNoteEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().Delete(iNVStoreIssueNoteEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<INVStoreIssueNoteEntity> IINVStoreIssueNoteFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IINVStoreIssueNoteFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        INVStoreIssueNoteEntity IINVStoreIssueNoteFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteEntity.FLD_NAME_StoreIssueNoteID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateINVStoreIssueNoteDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
