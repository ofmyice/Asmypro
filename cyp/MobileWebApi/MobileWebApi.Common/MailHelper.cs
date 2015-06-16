using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace MobileWebApi.Common
{
    public class MailHelper
    {
        #region

        ///// <summary>  
        ///// 添加附件  
        ///// </summary>  
        //public void Attachments(string Path)
        //{
        //    string[] path = Path.Split(',');
        //    Attachment data;
        //    ContentDisposition disposition;
        //    for (int i = 0; i < path.Length; i++)
        //    {
        //        data = new Attachment(path[i], MediaTypeNames.Application.Octet);//实例化 附件  
        //        disposition = data.ContentDisposition;
        //        disposition.CreationDate = System.IO.File.GetCreationTime(path[i]);//获取 附件的创建日期  
        //        disposition.ModificationDate = System.IO.File.GetLastWriteTime(path[i]);// 获取附件的修改日期  
        //        disposition.ReadDate = System.IO.File.GetLastAccessTime(path[i]);//获取附 件的读取日期  
        //        mailMessage.Attachments.Add(data);//添加到附件中  
        //    }
        //}
        ///// <summary>  
        ///// 异步发送邮件  
        ///// </summary>  
        ///// <param name="CompletedMethod"></param>  
        //public void SendAsync(SendCompletedEventHandler CompletedMethod)
        //{
        //    if (mailMessage != null)
        //    {
        //        smtpClient = new SmtpClient();
        //        smtpClient.Credentials = new System.Net.NetworkCredential(mailMessage.From.Address, password);//设置发件人身份的票据  
        //        smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
        //        smtpClient.Host = "smtp." + mailMessage.From.Host;
        //        smtpClient.SendCompleted += new SendCompletedEventHandler(CompletedMethod);//注册异步发送邮件完成时的事件  
        //        smtpClient.SendAsync(mailMessage, mailMessage.Body);
        //    }
        //}

        #endregion

        /// <summary>
        ///     发送邮件
        /// </summary>
        public static void Send(string e)
        {
            try
            {
                MailMessage mailMessage;
                SmtpClient smtpClient;
                mailMessage = new MailMessage();
                smtpClient = new SmtpClient();
                var map = new ExeConfigurationFileMap();
                map.ExeConfigFilename = HttpContext.Current.Server.MapPath("~/NLog.config");
                ;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);

                string strFrom = config.AppSettings.Settings["MailFrom"].Value;
                string strHost = config.AppSettings.Settings["MailHost"].Value;
                int intPort = Convert.ToInt32(config.AppSettings.Settings["MailPort"].Value);
                string strUserName = config.AppSettings.Settings["MailUserName"].Value;
                string strPassword = config.AppSettings.Settings["MailPassword"].Value;
                string systemName = config.AppSettings.Settings["SystemName"].Value;
                mailMessage.From = new MailAddress(strFrom, "CheYiPai Tech");
                mailMessage.Subject = "System Exception";
                mailMessage.Body = string.Format(@"各位同仁：</br>
                        {0}</br>
发生异常，异常信息为：</br>
{1}</br>
请提醒相关负责人处理异常！</br>
感谢工作配合!</br>
车易拍综合管理平台</br>
此邮件为系统邮件，请勿回复！", systemName, e);
                mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = Encoding.Default;
                mailMessage.Priority = MailPriority.Normal;
                string[] tempto = config.AppSettings.Settings["MailTo"].Value.Split(',');
                for (int i = 0; i < tempto.Length; i++)
                {
                    mailMessage.To.Add(tempto[i]); //收件人集合
                }
                smtpClient.Credentials = new NetworkCredential(strUserName, strPassword); //设置发件人身份的票据  
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Host = strHost;
                smtpClient.Send(mailMessage);
                smtpClient.Port = intPort;
            }
            catch
            {
            }
        }
    }
}