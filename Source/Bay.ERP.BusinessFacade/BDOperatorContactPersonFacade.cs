// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




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
    public sealed partial class BDOperatorContactPersonFacade : IBDOperatorContactPersonFacade
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

        public BDOperatorContactPersonFacade()
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

        ~BDOperatorContactPersonFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDOperatorContactPersonFacade.Add(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Add(bDOperatorContactPersonEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDOperatorContactPersonFacade.Update(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Update(bDOperatorContactPersonEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDOperatorContactPersonFacade.Delete(BDOperatorContactPersonEntity bDOperatorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Delete(bDOperatorContactPersonEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDOperatorContactPersonFacade.Add(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Add(bDOperatorContactPersonEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDOperatorContactPersonFacade.Update(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Update(bDOperatorContactPersonEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDOperatorContactPersonFacade.Delete(IList<BDOperatorContactPersonEntity> bDOperatorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().Delete(bDOperatorContactPersonEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDOperatorContactPersonEntity> IBDOperatorContactPersonFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDOperatorContactPersonFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDOperatorContactPersonEntity IBDOperatorContactPersonFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDOperatorContactPersonEntity.FLD_NAME_OperatorContactPersonID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDOperatorContactPersonDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
