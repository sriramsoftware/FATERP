// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Oct-2013, 02:28:24




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
    public sealed partial class MDAssetOwnerTypeFacade : IMDAssetOwnerTypeFacade
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

        public MDAssetOwnerTypeFacade()
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

        ~MDAssetOwnerTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDAssetOwnerTypeFacade.Add(MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Add(mDAssetOwnerTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAssetOwnerTypeFacade.Update(MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Update(mDAssetOwnerTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDAssetOwnerTypeFacade.Delete(MDAssetOwnerTypeEntity mDAssetOwnerTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Delete(mDAssetOwnerTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDAssetOwnerTypeFacade.Add(IList<MDAssetOwnerTypeEntity> mDAssetOwnerTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Add(mDAssetOwnerTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAssetOwnerTypeFacade.Update(IList<MDAssetOwnerTypeEntity> mDAssetOwnerTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Update(mDAssetOwnerTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDAssetOwnerTypeFacade.Delete(IList<MDAssetOwnerTypeEntity> mDAssetOwnerTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().Delete(mDAssetOwnerTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDAssetOwnerTypeEntity> IMDAssetOwnerTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDAssetOwnerTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDAssetOwnerTypeEntity IMDAssetOwnerTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDAssetOwnerTypeEntity.FLD_NAME_AssetOwnerTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDAssetOwnerTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
