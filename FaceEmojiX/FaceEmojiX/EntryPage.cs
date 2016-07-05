using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FaceEmojiX
{
    class EntryPage : ContentPage
    {
        public EntryPage()
        {
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.BackgroundColor = Color.Blue;


            //SizeChanged += 

            // Title defination
            Label faceTitle = new Label
            {
                Text = "FACE",
                FontSize = 150,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center
            };

            Label emojiTitle = new Label
            {
                Text = "EMOJI",
                FontSize = 150,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center
            };

            // Body defination which contains two btns
            Button pickButton = new Button
            {
                FontSize = 40,
                FontAttributes = FontAttributes.Italic,
                Text = "Pick!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Button safariButton = new Button
            {
                FontSize = 40,
                FontAttributes = FontAttributes.Italic,
                Text = "Safari!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            RelativeLayout relativeLayout = new RelativeLayout();

            relativeLayout.Children.Add(faceTitle,
                Constraint.RelativeToParent(
                    (parent) => { return 0; }),
                Constraint.RelativeToParent(
                    (parent) => { return 0; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height / 3; }));

            relativeLayout.Children.Add(emojiTitle,
                Constraint.RelativeToParent(
                    (parent) => { return 0; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height / 3; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height / 3; }));

            relativeLayout.Children.Add(pickButton,
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width / 4; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height * 4 / 6; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width * 4 / 8; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height / 6; }));

            relativeLayout.Children.Add(safariButton,
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width / 4; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height * 5 / 6; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Width * 4 / 8; }),
                Constraint.RelativeToParent(
                    (parent) => { return parent.Height / 6; }));

/*
            relativeLayout.Children.Add(pop,
                Constraint.RelativeToParent(
                        (parent) => { return 0; }),
                Constraint.RelativeToParent(
                        (parent) => { return parent.Height / 4; }),
                Constraint.RelativeToParent(
                        (parent) => { return parent.Width * 3 / 4; }),
                Constraint.RelativeToParent(
                        (parent) => { return parent.Height * 3 / 8; }));

 */

            // Button funcionality defination
/*
            pickButton.Clicked += (s, args) =>
            {
                StackLayout stack = new StackLayout
                {
                    BackgroundColor = Color.White
                };
                pop.Content = stack;
                stack.Children.Add(new Label
                {
                    Text = "Halo!"
                });
            };

*/
            this.Content = relativeLayout;
        }


        private bool bPopupMenuExist = false;
        //private PopupLayout pop = new PopupLayout();

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            View view = (View) sender;
            //double lineHeight = Device
        }
           
    }
}
