// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    public sealed partial class ACDepreciationMethodFacade : IACDepreciationMethodFacade
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

        public ACDepreciationMethodFacade()
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

        ~ACDepreciationMethodFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACDepreciationMethodFacade.Add(ACDepreciationMethodEntity aCDepreciationMethodEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Add(aCDepreciationMethodEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACDepreciationMethodFacade.Update(ACDepreciationMethodEntity aCDepreciationMethodEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Update(aCDepreciationMethodEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACDepreciationMethodFacade.Delete(ACDepreciationMethodEntity aCDepreciationMethodEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Delete(aCDepreciationMethodEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACDepreciationMethodFacade.Add(IList<ACDepreciationMethodEntity> aCDepreciationMethodEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Add(aCDepreciationMethodEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDepreciationMethodFacade.Update(IList<ACDepreciationMethodEntity> aCDepreciationMethodEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Update(aCDepreciationMethodEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACDepreciationMethodFacade.Delete(IList<ACDepreciationMethodEntity> aCDepreciationMethodEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().Delete(aCDepreciationMethodEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACDepreciationMethodEntity> IACDepreciationMethodFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACDepreciationMethodFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACDepreciationMethodDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACDepreciationMethodEntity IACDepreciationMethodFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACDepreciationMethodEntity.FLD_NAME_DepreciationMethodID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACDepreciationMethodDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
