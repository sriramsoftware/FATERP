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
    public sealed partial class BDProjectCollectedDocumentCategoryInfoFacade : IBDProjectCollectedDocumentCategoryInfoFacade
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

        public BDProjectCollectedDocumentCategoryInfoFacade()
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

        ~BDProjectCollectedDocumentCategoryInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectCollectedDocumentCategoryInfoFacade.Add(BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Add(bDProjectCollectedDocumentCategoryInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentCategoryInfoFacade.Update(BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Update(bDProjectCollectedDocumentCategoryInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectCollectedDocumentCategoryInfoFacade.Delete(BDProjectCollectedDocumentCategoryInfoEntity bDProjectCollectedDocumentCategoryInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Delete(bDProjectCollectedDocumentCategoryInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentCategoryInfoFacade.Add(IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Add(bDProjectCollectedDocumentCategoryInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentCategoryInfoFacade.Update(IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Update(bDProjectCollectedDocumentCategoryInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectCollectedDocumentCategoryInfoFacade.Delete(IList<BDProjectCollectedDocumentCategoryInfoEntity> bDProjectCollectedDocumentCategoryInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().Delete(bDProjectCollectedDocumentCategoryInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectCollectedDocumentCategoryInfoEntity> IBDProjectCollectedDocumentCategoryInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectCollectedDocumentCategoryInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectCollectedDocumentCategoryInfoEntity IBDProjectCollectedDocumentCategoryInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectCollectedDocumentCategoryInfoEntity.FLD_NAME_ProjectCollectedDocumentCategoryInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectCollectedDocumentCategoryInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
