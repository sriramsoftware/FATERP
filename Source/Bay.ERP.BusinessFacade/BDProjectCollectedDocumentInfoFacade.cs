// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Mar-2012, 03:28:59




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
    public sealed partial class BDProjectCollectedDocumentInfoFacade : IBDProjectCollectedDocumentInfoFacade
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

        public BDProjectCollectedDocumentInfoFacade()
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

        ~BDProjectCollectedDocumentInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectCollectedDocumentInfoFacade.Add(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Add(bDProjectCollectedDocumentInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentInfoFacade.Update(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Update(bDProjectCollectedDocumentInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentInfoFacade.Delete(BDProjectCollectedDocumentInfoEntity bDProjectCollectedDocumentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Delete(bDProjectCollectedDocumentInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentInfoFacade.Add(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Add(bDProjectCollectedDocumentInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentInfoFacade.Update(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Update(bDProjectCollectedDocumentInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentInfoFacade.Delete(IList<BDProjectCollectedDocumentInfoEntity> bDProjectCollectedDocumentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().Delete(bDProjectCollectedDocumentInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectCollectedDocumentInfoEntity> IBDProjectCollectedDocumentInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectCollectedDocumentInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectCollectedDocumentInfoEntity IBDProjectCollectedDocumentInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentInfoEntity.FLD_NAME_ProjectCollectedDocumentInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectCollectedDocumentInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
