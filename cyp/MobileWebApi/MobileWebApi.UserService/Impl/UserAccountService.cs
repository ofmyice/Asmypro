using System;
using MobileWebApi.Common;
using MobileWebApi.User.Domain;
using MobileWebApi.User.Service.UserWcfService;
using Newtonsoft.Json;

namespace MobileWebApi.User.Service.Impl
{
    public class UserAccountService : IUserAccountService
    {
        /// <summary>
        ///     资产中心首页信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string GetCapitalIndex(string uid)
        {
            var _capitalIndexInfo = new CapitalIndexInfo();
            _capitalIndexInfo.SetState(ResState.Success);
            _capitalIndexInfo.FreezeCarCount = 0;
            return JsonConvert.SerializeObject(_capitalIndexInfo);
        }

        /// <summary>
        ///     获取保证金信息
        /// </summary>
        public string GetEarnestInfo(string uid)
        {
            var _earnestInfo = new EarnestInfo();
            _earnestInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetEarnest(uid, Config.TokenKey);
                _earnestInfo.TotalMoney = mode.TotalMoney;
                _earnestInfo.FreezeMoney = mode.FreezeMoney;
                _earnestInfo.BlanceMoney = mode.BlanceMoney;
                _earnestInfo.FreezeCarNum = mode.FreezeCarNum;
            }
            return JsonConvert.SerializeObject(_earnestInfo);
        }

        /// <summary>
        ///     获取保证金流水列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="begintTime"></param>
        /// <param name="tag"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public string GetEarnestLogList(string uid, DateTime begintTime, string tag, string pageIndex, string pageSize)
        {
            var _earnestListInfo = new EarnestListInfo();
            _earnestListInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetEarnestLog(uid, begintTime, Convert.ToInt32(tag), Convert.ToInt32(pageIndex),
                    Convert.ToInt32(pageSize), Config.TokenKey);
                _earnestListInfo.Data = mode.DataList;
                _earnestListInfo.TotalCount = mode.TotalCount;
            }
            return JsonConvert.SerializeObject(_earnestListInfo);
        }

        /// <summary>
        ///     获取代金币信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string GetVoucherInfo(string uid)
        {
            var _voucherInfo = new VoucherInfo();
            _voucherInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetVoucherInfo(uid, Config.TokenKey);
                _voucherInfo.GeneralVoucher = mode.GeneralVoucher;
                _voucherInfo.ContributeVoucher = mode.ContributeVoucher;
                _voucherInfo.GenContributeVoucher = mode.GenContributeVoucher;
            }
            return JsonConvert.SerializeObject(_voucherInfo);
        }

        /// <summary>
        ///     使用界面获取代金币信息
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="carid"></param>
        /// <returns></returns>
        public string GetVoucherInfoInUse(string uid, string carid)
        {
            var _voucherUseInfo = new VoucherUseInfo();
            _voucherUseInfo.SetState(ResState.Success);
            return JsonConvert.SerializeObject(_voucherUseInfo);
        }

        /// <summary>
        ///     获取代金币列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="type"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public string GetVoucherLogList(string uid, string type, string pageIndex, string pageSize)
        {
            var _voucherListInfo = new VoucherListInfo();
            _voucherListInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetVoucherList(Convert.ToInt32(uid), Convert.ToInt32(type), Convert.ToInt32(pageIndex),
                    Convert.ToInt32(pageSize), Config.TokenKey);
                _voucherListInfo.Data = mode.DataList;
                _voucherListInfo.TotalCount = mode.TotalCount;
            }
            return JsonConvert.SerializeObject(_voucherListInfo);
        }

        /// <summary>
        ///     获取商信通账户信息
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string GetBusinessSxtInfo(string uid)
        {
            var _businessSxtInfo = new BusinessSxtInfo();
            _businessSxtInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetUserSxtInfo(Convert.ToInt32(uid), Config.TokenKey);
                _businessSxtInfo.IsSXT = mode.IfSXT;
                _businessSxtInfo.TotalLoan = mode.TotalLoan;
                _businessSxtInfo.FrezeLoan = mode.TotalLoan-mode.LeftLoan;
                _businessSxtInfo.LeftLoan = mode.LeftLoan;
            }
            return JsonConvert.SerializeObject(_businessSxtInfo);
        }

        /// <summary>
        ///     获取商信通还款列表
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public string GetSxtList(string uid, string pageIndex, string pageSize)
        {
            var _businessSxtListInfo = new BusinessSxtListInfo();
            _businessSxtListInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetSxtList(Convert.ToInt32(uid),Convert.ToInt32(pageIndex),Convert.ToInt32(pageSize), Config.TokenKey);
                _businessSxtListInfo.TotalCount = mode.TotalCount;
                _businessSxtListInfo.Data = mode.DataList;
            }
            return JsonConvert.SerializeObject(_businessSxtListInfo);
        }

        /// <summary>
        /// 获取头像地址
        /// </summary>
        /// <param name="uid"></param>
        /// <returns></returns>
        public string GetHeadImg(string uid)
        {
            HeadImgInfo _headImgInfo = new HeadImgInfo();
            _headImgInfo.SetState(ResState.Success);
            using (UserWcfService.UserSerWCFClient c = new UserSerWCFClient())
            {
                var mode = c.GetHeadImgInfo(Convert.ToInt32(uid), Config.TokenKey);
                _headImgInfo.HeadImgUrl = mode.HeadImgUrl;
                _headImgInfo.HeadImg = mode.HeadImg;
            }
            return JsonConvert.SerializeObject(_headImgInfo);
        }
    }
}