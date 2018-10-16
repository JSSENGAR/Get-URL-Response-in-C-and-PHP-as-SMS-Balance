 using System;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using System.IO;
using System.Data;
using RestSharp;
using System.Configuration;

namespace C#URL
{
    public class CSHURL
    {
       
 
		public string sms_bal()
        {
            string result = "";
            WebRequest request = null;
            HttpWebResponse response = null;

            String url = "http://enterprise.smsgupshup.com/apps/apis/accInfo?userid="+C_Name("SMS_UID") +"&password="+C_Name("SMS_PWD") +"&method=balanceCheck";


            request = WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader reader = new
            System.IO.StreamReader(stream, ec);
            result = reader.ReadToEnd();            
            reader.Close();
            stream.Close();
            return result;
        }
	}
}