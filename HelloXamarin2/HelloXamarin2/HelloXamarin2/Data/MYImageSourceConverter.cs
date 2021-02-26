using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace HelloXamarin2.Data
{
    //Attığımız resimleri tek dosyadan okutacağız.
    //    iOs için Droid için aynı olacak.
    //Bunun için ek olarak resimler> Properties > Build Action = EmbeddedResource yapmalıyız yoksa resim gormuyor 
    public class MYImageSourceConverter : IValueConverter
    {
        //İlk çalışacak method
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ImageSource.FromResource("HelloXamarin2.images." + (value ?? ""));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
