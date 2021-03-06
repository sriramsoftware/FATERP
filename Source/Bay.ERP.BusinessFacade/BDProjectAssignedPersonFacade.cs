// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-Jul-2012, 05:23:43




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
    public sealed partial class BDProjectAssignedPersonFacade : IBDProjectAssignedPersonFacade
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

        public BDProjectAssignedPersonFacade()
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

        ~BDProjectAssignedPersonFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectAssignedPersonFacade.Add(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Add(bDProjectAssignedPersonEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectAssignedPersonFacade.Update(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Update(bDProjectAssignedPersonEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectAssignedPersonFacade.Delete(BDProjectAssignedPersonEntity bDProjectAssignedPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Delete(bDProjectAssignedPersonEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectAssignedPersonFacade.Add(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Add(bDProjectAssignedPersonEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectAssignedPersonFacade.Update(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Update(bDProjectAssignedPersonEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectAssignedPersonFacade.Delete(IList<BDProjectAssignedPersonEntity> bDProjectAssignedPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().Delete(bDProjectAssignedPersonEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectAssignedPersonEntity> IBDProjectAssignedPersonFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectAssignedPersonFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectAssignedPersonEntity IBDProjectAssignedPersonFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectAssignedPersonEntity.FLD_NAME_ProjectAssignedPersonID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectAssignedPersonDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
