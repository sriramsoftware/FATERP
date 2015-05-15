// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2013, 03:54:41




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
    public sealed partial class ACAccountResourceAccountMapFacade : IACAccountResourceAccountMapFacade
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

        public ACAccountResourceAccountMapFacade()
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

        ~ACAccountResourceAccountMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACAccountResourceAccountMapFacade.Add(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Add(aCAccountResourceAccountMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACAccountResourceAccountMapFacade.Update(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Update(aCAccountResourceAccountMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACAccountResourceAccountMapFacade.Delete(ACAccountResourceAccountMapEntity aCAccountResourceAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Delete(aCAccountResourceAccountMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACAccountResourceAccountMapFacade.Add(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Add(aCAccountResourceAccountMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACAccountResourceAccountMapFacade.Update(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Update(aCAccountResourceAccountMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACAccountResourceAccountMapFacade.Delete(IList<ACAccountResourceAccountMapEntity> aCAccountResourceAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().Delete(aCAccountResourceAccountMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACAccountResourceAccountMapEntity> IACAccountResourceAccountMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACAccountResourceAccountMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACAccountResourceAccountMapEntity IACAccountResourceAccountMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACAccountResourceAccountMapEntity.FLD_NAME_ResourceAccountMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACAccountResourceAccountMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
