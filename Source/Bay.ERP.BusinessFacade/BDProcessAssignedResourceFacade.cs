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
    public sealed partial class BDProcessAssignedResourceFacade : IBDProcessAssignedResourceFacade
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

        public BDProcessAssignedResourceFacade()
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

        ~BDProcessAssignedResourceFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProcessAssignedResourceFacade.Add(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Add(bDProcessAssignedResourceEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProcessAssignedResourceFacade.Update(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Update(bDProcessAssignedResourceEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProcessAssignedResourceFacade.Delete(BDProcessAssignedResourceEntity bDProcessAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Delete(bDProcessAssignedResourceEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceFacade.Add(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Add(bDProcessAssignedResourceEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceFacade.Update(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Update(bDProcessAssignedResourceEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceFacade.Delete(IList<BDProcessAssignedResourceEntity> bDProcessAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().Delete(bDProcessAssignedResourceEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProcessAssignedResourceEntity> IBDProcessAssignedResourceFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProcessAssignedResourceFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProcessAssignedResourceEntity IBDProcessAssignedResourceFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceEntity.FLD_NAME_ProcessAssignedResourceID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProcessAssignedResourceDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
