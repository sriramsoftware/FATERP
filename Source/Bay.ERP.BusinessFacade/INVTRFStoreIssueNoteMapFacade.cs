// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Jan-2013, 04:16:20




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
    public sealed partial class INVTRFStoreIssueNoteMapFacade : IINVTRFStoreIssueNoteMapFacade
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

        public INVTRFStoreIssueNoteMapFacade()
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

        ~INVTRFStoreIssueNoteMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IINVTRFStoreIssueNoteMapFacade.Add(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Add(iNVTRFStoreIssueNoteMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IINVTRFStoreIssueNoteMapFacade.Update(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Update(iNVTRFStoreIssueNoteMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IINVTRFStoreIssueNoteMapFacade.Delete(INVTRFStoreIssueNoteMapEntity iNVTRFStoreIssueNoteMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Delete(iNVTRFStoreIssueNoteMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IINVTRFStoreIssueNoteMapFacade.Add(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Add(iNVTRFStoreIssueNoteMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVTRFStoreIssueNoteMapFacade.Update(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Update(iNVTRFStoreIssueNoteMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IINVTRFStoreIssueNoteMapFacade.Delete(IList<INVTRFStoreIssueNoteMapEntity> iNVTRFStoreIssueNoteMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().Delete(iNVTRFStoreIssueNoteMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<INVTRFStoreIssueNoteMapEntity> IINVTRFStoreIssueNoteMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IINVTRFStoreIssueNoteMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        INVTRFStoreIssueNoteMapEntity IINVTRFStoreIssueNoteMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(INVTRFStoreIssueNoteMapEntity.FLD_NAME_TRFStoreIssueNoteMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateINVTRFStoreIssueNoteMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
