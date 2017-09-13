using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Bumptech.Glide;
using Com.Bumptech.Glide.Request;

namespace GlideQs
{
    [Activity(Label = "GlideQs", Theme = "@style/MyTheme", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var imgTest = FindViewById<ImageView>(Resource.Id.imgTest);

            Glide.With(this).Load("https://scontent.fhan2-3.fna.fbcdn.net/v/t1.0-9/21231281_1462647560478655_5948244291370274738_n.jpg?oh=44119c06d2babac9abaa9b45fa6620d3&oe=5A4581D3").Apply(RequestOptions.CircleCropTransform()).Into(imgTest);
        }
    }
}

