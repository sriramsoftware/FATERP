// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Jul-2013, 12:43:35




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
    public sealed partial class BDProcessAssignedResourceMapFacade : IBDProcessAssignedResourceMapFacade
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

        public BDProcessAssignedResourceMapFacade()
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

        ~BDProcessAssignedResourceMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProcessAssignedResourceMapFacade.Add(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Add(bDProcessAssignedResourceMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProcessAssignedResourceMapFacade.Update(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Update(bDProcessAssignedResourceMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProcessAssignedResourceMapFacade.Delete(BDProcessAssignedResourceMapEntity bDProcessAssignedResourceMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Delete(bDProcessAssignedResourceMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceMapFacade.Add(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Add(bDProcessAssignedResourceMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceMapFacade.Update(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Update(bDProcessAssignedResourceMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProcessAssignedResourceMapFacade.Delete(IList<BDProcessAssignedResourceMapEntity> bDProcessAssignedResourceMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().Delete(bDProcessAssignedResourceMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProcessAssignedResourceMapEntity> IBDProcessAssignedResourceMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProcessAssignedResourceMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProcessAssignedResourceMapEntity IBDProcessAssignedResourceMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProcessAssignedResourceMapEntity.FLD_NAME_ProcessAssignedResourceMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProcessAssignedResourceMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
