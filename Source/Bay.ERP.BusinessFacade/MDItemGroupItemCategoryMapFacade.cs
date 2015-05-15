// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




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
    public sealed partial class MDItemGroupItemCategoryMapFacade : IMDItemGroupItemCategoryMapFacade
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

        public MDItemGroupItemCategoryMapFacade()
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

        ~MDItemGroupItemCategoryMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDItemGroupItemCategoryMapFacade.Add(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Add(mDItemGroupItemCategoryMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDItemGroupItemCategoryMapFacade.Update(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Update(mDItemGroupItemCategoryMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDItemGroupItemCategoryMapFacade.Delete(MDItemGroupItemCategoryMapEntity mDItemGroupItemCategoryMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Delete(mDItemGroupItemCategoryMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDItemGroupItemCategoryMapFacade.Add(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Add(mDItemGroupItemCategoryMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDItemGroupItemCategoryMapFacade.Update(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Update(mDItemGroupItemCategoryMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDItemGroupItemCategoryMapFacade.Delete(IList<MDItemGroupItemCategoryMapEntity> mDItemGroupItemCategoryMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().Delete(mDItemGroupItemCategoryMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDItemGroupItemCategoryMapEntity> IMDItemGroupItemCategoryMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDItemGroupItemCategoryMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDItemGroupItemCategoryMapEntity IMDItemGroupItemCategoryMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemGroupItemCategoryMapEntity.FLD_NAME_ItemGroupItemCategoryMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDItemGroupItemCategoryMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
