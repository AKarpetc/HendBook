using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using clientapi.instaforex.com.Calendar;

namespace HendBook.Modules
{
    class GoogleApiClass
    {
        public GoogleApiClass()
        {

            EndPoint = new EndpointAddress("https://client-api.instaforex.org/soapservices/Calendar.svc/secure");
            

        }
        public  EndpointAddress EndPoint;//= new EndpointAddress("https://client-api.instaforex.org/soapservices/Calendar.svc/secure");
        private static BasicHttpBinding CreateBasicHttp()
        {
            BasicHttpBinding binding = new BasicHttpBinding
            {
                Name = "BasicHttpBinding",
                MaxReceivedMessageSize = 2147483647,
                Security =new BasicHttpSecurity {Mode=BasicHttpSecurityMode.Transport },
                 
  
                  
            };
           
            //TimeSpan timeout = new TimeSpan(0, 5,0);
            //binding.SendTimeout = timeout;
            //binding.OpenTimeout = timeout;
            //binding.ReceiveTimeout = timeout;
            return binding;
        }
        CalendarServiceClient sc;
        public void GetEvents()
        {
            BasicHttpBinding binding = CreateBasicHttp();
        
                     
           
            
           // var test = sc.ClientCredentials.UserName.UserName= "UserName";
            try
            {
                sc = new CalendarServiceClient(binding, EndPoint);
                sc.GetCalendarCompleted += Sc_GetCalendarCompleted;
                sc.GetCalendarAsync(Lang.Ru, new Account { Login = 1370181, Password = "78Kap11" });
                
                


                // sc.Close();
            }
            catch (Exception ex)
            {
                sc.Close();
            }
          


        }

        private void Sc_GetCalendarCompleted(object sender, GetCalendarCompletedEventArgs e)
        {
            var text = e.Result;
            sc.Close();
        }

        private void Sc_GetCalendarByDateCompleted(object sender, GetCalendarByDateCompletedEventArgs e)
        {
            sc.Close();
           // throw new NotImplementedException();
        }

       
    }
}