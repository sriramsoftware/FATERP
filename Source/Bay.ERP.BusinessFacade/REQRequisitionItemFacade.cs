// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jun-2012, 11:52:40




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
    public sealed partial class REQRequisitionItemFacade : IREQRequisitionItemFacade
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

        public REQRequisitionItemFacade()
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

        ~REQRequisitionItemFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IREQRequisitionItemFacade.Add(REQRequisitionItemEntity rEQRequisitionItemEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Add(rEQRequisitionItemEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionItemFacade.Update(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Update(rEQRequisitionItemEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionItemFacade.Delete(REQRequisitionItemEntity rEQRequisitionItemEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Delete(rEQRequisitionItemEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IREQRequisitionItemFacade.Add(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Add(rEQRequisitionItemEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionItemFacade.Update(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Update(rEQRequisitionItemEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionItemFacade.Delete(IList<REQRequisitionItemEntity> rEQRequisitionItemEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().Delete(rEQRequisitionItemEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<REQRequisitionItemEntity> IREQRequisitionItemFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IREQRequisitionItemFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionItemDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        REQRequisitionItemEntity IREQRequisitionItemFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemEntity.FLD_NAME_RequisitionItemID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateREQRequisitionItemDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
