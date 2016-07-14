using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;


namespace FaceEmojiX.Droid
{
    [Activity(Label = "SafariSearchActivity")]
    public class SafariSearchActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
                        
        }
    }

    public class DownloadImageData
    {
        public static Bitmap[] bitmaps = null;
    }


    public class MarkableImageAdapter : BaseAdapter
    {
        private Context context;

        public MarkableImageAdapter(Context c)
        {
            this.context = c;
        }

        public override int Count
        {
            get
            {
                return DownloadImageData.bitmaps.Length;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            return null;                
        }

    }

}