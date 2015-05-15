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
    public sealed partial class ACItemGroupAccountMapFacade : IACItemGroupAccountMapFacade
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

        public ACItemGroupAccountMapFacade()
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

        ~ACItemGroupAccountMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACItemGroupAccountMapFacade.Add(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Add(aCItemGroupAccountMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACItemGroupAccountMapFacade.Update(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Update(aCItemGroupAccountMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACItemGroupAccountMapFacade.Delete(ACItemGroupAccountMapEntity aCItemGroupAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Delete(aCItemGroupAccountMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACItemGroupAccountMapFacade.Add(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Add(aCItemGroupAccountMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACItemGroupAccountMapFacade.Update(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Update(aCItemGroupAccountMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACItemGroupAccountMapFacade.Delete(IList<ACItemGroupAccountMapEntity> aCItemGroupAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().Delete(aCItemGroupAccountMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACItemGroupAccountMapEntity> IACItemGroupAccountMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACItemGroupAccountMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACItemGroupAccountMapEntity IACItemGroupAccountMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACItemGroupAccountMapEntity.FLD_NAME_ItemGroupAccountMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACItemGroupAccountMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
