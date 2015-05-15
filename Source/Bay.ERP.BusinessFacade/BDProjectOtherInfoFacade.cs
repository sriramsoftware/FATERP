// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public sealed partial class BDProjectOtherInfoFacade : IBDProjectOtherInfoFacade
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

        public BDProjectOtherInfoFacade()
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

        ~BDProjectOtherInfoFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectOtherInfoFacade.Add(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Add(bDProjectOtherInfoEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectOtherInfoFacade.Update(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Update(bDProjectOtherInfoEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectOtherInfoFacade.Delete(BDProjectOtherInfoEntity bDProjectOtherInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Delete(bDProjectOtherInfoEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectOtherInfoFacade.Add(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Add(bDProjectOtherInfoEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectOtherInfoFacade.Update(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Update(bDProjectOtherInfoEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectOtherInfoFacade.Delete(IList<BDProjectOtherInfoEntity> bDProjectOtherInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().Delete(bDProjectOtherInfoEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectOtherInfoEntity> IBDProjectOtherInfoFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectOtherInfoFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectOtherInfoEntity IBDProjectOtherInfoFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectOtherInfoEntity.FLD_NAME_ProjectOtherInfoID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectOtherInfoDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
