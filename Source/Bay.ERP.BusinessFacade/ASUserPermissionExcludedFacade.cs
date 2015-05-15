// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




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
    public sealed partial class ASUserPermissionExcludedFacade : IASUserPermissionExcludedFacade
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

        public ASUserPermissionExcludedFacade()
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

        ~ASUserPermissionExcludedFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IASUserPermissionExcludedFacade.Add(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Add(aSUserPermissionExcludedEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IASUserPermissionExcludedFacade.Update(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Update(aSUserPermissionExcludedEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IASUserPermissionExcludedFacade.Delete(ASUserPermissionExcludedEntity aSUserPermissionExcludedEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Delete(aSUserPermissionExcludedEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IASUserPermissionExcludedFacade.Add(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Add(aSUserPermissionExcludedEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASUserPermissionExcludedFacade.Update(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Update(aSUserPermissionExcludedEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IASUserPermissionExcludedFacade.Delete(IList<ASUserPermissionExcludedEntity> aSUserPermissionExcludedEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().Delete(aSUserPermissionExcludedEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ASUserPermissionExcludedEntity> IASUserPermissionExcludedFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IASUserPermissionExcludedFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ASUserPermissionExcludedEntity IASUserPermissionExcludedFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ASUserPermissionExcludedEntity.FLD_NAME_ASUserPermissionExcludedID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateASUserPermissionExcludedDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
