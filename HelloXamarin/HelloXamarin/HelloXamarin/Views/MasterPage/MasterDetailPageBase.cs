using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HelloXamarin.Views.MasterPage
{
    public class MasterDetailPageBase : MasterDetailPage
    {
        //Uygulamadaki sayfaları iki bölmeli şekilde yöneten kontrol
        //Menu ve Detail yapımı olarak kullanıyoruz
        public MasterDetailPageBase()
        {
            Master = new MyMaster();
            Detail = new MyDetail();
        }
    }
}
