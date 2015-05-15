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
    public sealed partial class BDProjectCollectedDocumentUploadInfoFacade : IBDProjectCollectedDocumentUploadInfoFacade
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

        public BDProjectCollectedDocumentUploadInfoFacade()
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

        ~BDProjectCollectedDocumentUploadInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectCollectedDocumentUploadInfoFacade.Add(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Add(bDProjectCollectedDocumentUploadInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentUploadInfoFacade.Update(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Update(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentUploadInfoFacade.Delete(BDProjectCollectedDocumentUploadInfoEntity bDProjectCollectedDocumentUploadInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Delete(bDProjectCollectedDocumentUploadInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentUploadInfoFacade.Add(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Add(bDProjectCollectedDocumentUploadInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentUploadInfoFacade.Update(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Update(bDProjectCollectedDocumentUploadInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentUploadInfoFacade.Delete(IList<BDProjectCollectedDocumentUploadInfoEntity> bDProjectCollectedDocumentUploadInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().Delete(bDProjectCollectedDocumentUploadInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectCollectedDocumentUploadInfoEntity> IBDProjectCollectedDocumentUploadInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectCollectedDocumentUploadInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectCollectedDocumentUploadInfoEntity IBDProjectCollectedDocumentUploadInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentUploadInfoEntity.FLD_NAME_ProjectCollectedDocumentUploadInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectCollectedDocumentUploadInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
