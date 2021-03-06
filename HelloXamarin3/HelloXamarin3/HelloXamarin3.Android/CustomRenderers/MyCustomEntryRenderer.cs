using HelloXamarin3.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(Entry), typeof(MyCustomEntryRenderer))]
namespace HelloXamarin3.Droid.CustomRenderers
{
    [System.Obsolete]
    public class MyCustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Red);
                Control.SetTextColor(Android.Graphics.Color.Aqua);
            }
        }
    }
}