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
    public sealed partial class BDMDRepeatCategoryFacade : IBDMDRepeatCategoryFacade
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

        public BDMDRepeatCategoryFacade()
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

        ~BDMDRepeatCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDMDRepeatCategoryFacade.Add(BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Add(bDMDRepeatCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDRepeatCategoryFacade.Update(BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Update(bDMDRepeatCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDMDRepeatCategoryFacade.Delete(BDMDRepeatCategoryEntity bDMDRepeatCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Delete(bDMDRepeatCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDMDRepeatCategoryFacade.Add(IList<BDMDRepeatCategoryEntity> bDMDRepeatCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Add(bDMDRepeatCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDRepeatCategoryFacade.Update(IList<BDMDRepeatCategoryEntity> bDMDRepeatCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Update(bDMDRepeatCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDMDRepeatCategoryFacade.Delete(IList<BDMDRepeatCategoryEntity> bDMDRepeatCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().Delete(bDMDRepeatCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDMDRepeatCategoryEntity> IBDMDRepeatCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDMDRepeatCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDMDRepeatCategoryEntity IBDMDRepeatCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDMDRepeatCategoryEntity.FLD_NAME_RepeatCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDMDRepeatCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
