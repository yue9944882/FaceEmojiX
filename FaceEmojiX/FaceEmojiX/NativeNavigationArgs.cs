using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FaceEmojiX
{
    public class NativeNavigationArgs
    {
        public Page page { get; private set; }

        public NativeNavigationArgs(Page page)
        {
            this.page = page;
        }
    }
}
