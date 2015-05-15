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
    public sealed partial class ACItemAccountMapFacade : IACItemAccountMapFacade
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

        public ACItemAccountMapFacade()
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

        ~ACItemAccountMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IACItemAccountMapFacade.Add(ACItemAccountMapEntity aCItemAccountMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Add(aCItemAccountMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IACItemAccountMapFacade.Update(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Update(aCItemAccountMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IACItemAccountMapFacade.Delete(ACItemAccountMapEntity aCItemAccountMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Delete(aCItemAccountMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IACItemAccountMapFacade.Add(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Add(aCItemAccountMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACItemAccountMapFacade.Update(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Update(aCItemAccountMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IACItemAccountMapFacade.Delete(IList<ACItemAccountMapEntity> aCItemAccountMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().Delete(aCItemAccountMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<ACItemAccountMapEntity> IACItemAccountMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IACItemAccountMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateACItemAccountMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        ACItemAccountMapEntity IACItemAccountMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(ACItemAccountMapEntity.FLD_NAME_ItemAccountMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateACItemAccountMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
