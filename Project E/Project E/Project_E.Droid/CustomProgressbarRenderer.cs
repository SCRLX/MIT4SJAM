using Android.Renderscripts;
using Project_E.Droid;
using Project_E.Utilities;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomProgressbar),typeof(CustomProgressbarRenderer))]
namespace Project_E.Droid
{
    public class CustomProgressbarRenderer  : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null || this.Element == null)
                return;
            if (Control != null)
            {
                Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(153,184,152), Android.Graphics.PorterDuff.Mode.SrcIn);
                Control.Progress = (int)Element.Progress;
            }
            SetNativeControl(this.Control);
        }
        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Control == null || Element == null)
                return;

            if (e.PropertyName == "Progress")
            {
                Control.Progress = (int)Element.Progress;
            }

        }

    }
}