// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Nov-2013, 10:23:55




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
    public sealed partial class REQRequisitionItemFloorDetailFacade : IREQRequisitionItemFloorDetailFacade
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

        public REQRequisitionItemFloorDetailFacade()
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

        ~REQRequisitionItemFloorDetailFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IREQRequisitionItemFloorDetailFacade.Add(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Add(rEQRequisitionItemFloorDetailEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionItemFloorDetailFacade.Update(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Update(rEQRequisitionItemFloorDetailEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IREQRequisitionItemFloorDetailFacade.Delete(REQRequisitionItemFloorDetailEntity rEQRequisitionItemFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Delete(rEQRequisitionItemFloorDetailEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IREQRequisitionItemFloorDetailFacade.Add(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Add(rEQRequisitionItemFloorDetailEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionItemFloorDetailFacade.Update(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Update(rEQRequisitionItemFloorDetailEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IREQRequisitionItemFloorDetailFacade.Delete(IList<REQRequisitionItemFloorDetailEntity> rEQRequisitionItemFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().Delete(rEQRequisitionItemFloorDetailEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<REQRequisitionItemFloorDetailEntity> IREQRequisitionItemFloorDetailFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IREQRequisitionItemFloorDetailFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        REQRequisitionItemFloorDetailEntity IREQRequisitionItemFloorDetailFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionItemFloorDetailEntity.FLD_NAME_RequisitionItemFloorDetailID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateREQRequisitionItemFloorDetailDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
