// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Feb-2013, 04:16:42




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
    public sealed partial class CMBillMaterialReceiveMeasurementBookMapFacade : ICMBillMaterialReceiveMeasurementBookMapFacade
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

        public CMBillMaterialReceiveMeasurementBookMapFacade()
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

        ~CMBillMaterialReceiveMeasurementBookMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMBillMaterialReceiveMeasurementBookMapFacade.Add(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Add(cMBillMaterialReceiveMeasurementBookMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillMaterialReceiveMeasurementBookMapFacade.Update(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Update(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMBillMaterialReceiveMeasurementBookMapFacade.Delete(CMBillMaterialReceiveMeasurementBookMapEntity cMBillMaterialReceiveMeasurementBookMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Delete(cMBillMaterialReceiveMeasurementBookMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapFacade.Add(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Add(cMBillMaterialReceiveMeasurementBookMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapFacade.Update(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Update(cMBillMaterialReceiveMeasurementBookMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMBillMaterialReceiveMeasurementBookMapFacade.Delete(IList<CMBillMaterialReceiveMeasurementBookMapEntity> cMBillMaterialReceiveMeasurementBookMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().Delete(cMBillMaterialReceiveMeasurementBookMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMBillMaterialReceiveMeasurementBookMapEntity> ICMBillMaterialReceiveMeasurementBookMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMBillMaterialReceiveMeasurementBookMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMBillMaterialReceiveMeasurementBookMapEntity ICMBillMaterialReceiveMeasurementBookMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillMaterialReceiveMeasurementBookMapEntity.FLD_NAME_BillMaterialReceiveMeasurementBookMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMBillMaterialReceiveMeasurementBookMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
