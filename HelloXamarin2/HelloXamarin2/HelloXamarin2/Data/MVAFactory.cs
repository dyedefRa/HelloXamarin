using HelloXamarin2.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace HelloXamarin2.Data
{
    public class MVAFactory
    {

        public class MVA
        {
            public string Title { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
            public DateTime PublishedDate { get; set; }
        }

        public static IList<MVA> MVAData { get; set; }

        static MVAFactory()
        {
            MVAData = new ObservableCollection<MVA>();
            MVAData.Add(new MVA() { Title = "Test 1 Örnek Başlığı", Description = "Tanım 1 Örnek Tanımı", ImageUrl = "1.png", PublishedDate = DateTime.Now });
            MVAData.Add(new MVA() { Title = "Test 2 Örnek Başlığı", Description = "Tanım 2 Örnek Tanımı", ImageUrl = "2.png", PublishedDate = DateTime.Now });
            MVAData.Add(new MVA() { Title = "Test 3 Örnek Başlığı", Description = "Tanım 3 Örnek Tanımı", ImageUrl = "3.png", PublishedDate = DateTime.Now });
            MVAData.Add(new MVA() { Title = "Test 4 Örnek Başlığı", Description = "Tanım 4 Örnek Tanımı", ImageUrl = "4.png", PublishedDate = DateTime.Now });
            MVAData.Add(new MVA() { Title = "Test 5 Örnek Başlığı", Description = "Tanım 5 Örnek Tanımı", ImageUrl = "5.png", PublishedDate = DateTime.Now });
            MVAData.Add(new MVA() { Title = "Test 6 Örnek Başlığı", Description = "Tanım 6 Örnek Tanımı", ImageUrl = "6.png", PublishedDate = DateTime.Now });
        }


        //--
        public static IList<MVA> MVADataGrouping { get; set; }
        public static ObservableCollection<MyGrouping<string,MVA>> BindingGroupData()
        {
            var result = MVAData;
            var list = new ObservableCollection<MyGrouping<string, MVA>>
                (result
                .OrderBy(c => c.Title)
                .GroupBy(c => c.Title[0].ToString())
                .Select(k => new MyGrouping<string, MVA>(k.Key, k)));


                return list;
        }
}
}
