// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public sealed partial class BDProjectWaterReserviorFacade : IBDProjectWaterReserviorFacade
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

        public BDProjectWaterReserviorFacade()
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

        ~BDProjectWaterReserviorFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectWaterReserviorFacade.Add(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Add(bDProjectWaterReserviorEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectWaterReserviorFacade.Update(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Update(bDProjectWaterReserviorEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectWaterReserviorFacade.Delete(BDProjectWaterReserviorEntity bDProjectWaterReserviorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Delete(bDProjectWaterReserviorEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectWaterReserviorFacade.Add(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Add(bDProjectWaterReserviorEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectWaterReserviorFacade.Update(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Update(bDProjectWaterReserviorEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectWaterReserviorFacade.Delete(IList<BDProjectWaterReserviorEntity> bDProjectWaterReserviorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().Delete(bDProjectWaterReserviorEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectWaterReserviorEntity> IBDProjectWaterReserviorFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectWaterReserviorFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectWaterReserviorEntity IBDProjectWaterReserviorFacade.GetByID(Int64 iD)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectWaterReserviorEntity.FLD_NAME_ProjectWaterReserviorID, iD.ToString(), SQLMatchType.Equal);

            return DataAccessFactory.CreateBDProjectWaterReserviorDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
