// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2013, 03:06:02




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
    public sealed partial class INVStoreIssueNoteItemMapFacade : IINVStoreIssueNoteItemMapFacade
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

        public INVStoreIssueNoteItemMapFacade()
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

        ~INVStoreIssueNoteItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IINVStoreIssueNoteItemMapFacade.Add(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Add(iNVStoreIssueNoteItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IINVStoreIssueNoteItemMapFacade.Update(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Update(iNVStoreIssueNoteItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IINVStoreIssueNoteItemMapFacade.Delete(INVStoreIssueNoteItemMapEntity iNVStoreIssueNoteItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Delete(iNVStoreIssueNoteItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteItemMapFacade.Add(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Add(iNVStoreIssueNoteItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteItemMapFacade.Update(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Update(iNVStoreIssueNoteItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVStoreIssueNoteItemMapFacade.Delete(IList<INVStoreIssueNoteItemMapEntity> iNVStoreIssueNoteItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().Delete(iNVStoreIssueNoteItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<INVStoreIssueNoteItemMapEntity> IINVStoreIssueNoteItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IINVStoreIssueNoteItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        INVStoreIssueNoteItemMapEntity IINVStoreIssueNoteItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateINVStoreIssueNoteItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
