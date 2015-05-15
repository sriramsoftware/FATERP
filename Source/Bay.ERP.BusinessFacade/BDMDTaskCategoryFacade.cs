// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2013, 02:32:38




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
    public sealed partial class BDMDTaskCategoryFacade : IBDMDTaskCategoryFacade
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

        public BDMDTaskCategoryFacade()
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

        ~BDMDTaskCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDMDTaskCategoryFacade.Add(BDMDTaskCategoryEntity bDMDTaskCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Add(bDMDTaskCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDTaskCategoryFacade.Update(BDMDTaskCategoryEntity bDMDTaskCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Update(bDMDTaskCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDTaskCategoryFacade.Delete(BDMDTaskCategoryEntity bDMDTaskCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Delete(bDMDTaskCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDMDTaskCategoryFacade.Add(IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Add(bDMDTaskCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDTaskCategoryFacade.Update(IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Update(bDMDTaskCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDTaskCategoryFacade.Delete(IList<BDMDTaskCategoryEntity> bDMDTaskCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().Delete(bDMDTaskCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDMDTaskCategoryEntity> IBDMDTaskCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDMDTaskCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDMDTaskCategoryEntity IBDMDTaskCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDTaskCategoryEntity.FLD_NAME_TaskCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDMDTaskCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}