using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace FaceEmojiX
{
    public class EntryPage : ContentPage
    {
        private View popupView = null;

        public Button pickButton = null;
        public Button safariButton = null;

        private bool bPopupViewExist
        {
            get { return popupView != null; }
        }


        public EntryPage()
        {

            //buttonAction = DependencyService.Get<IButtonAction>();

            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
            this.BackgroundColor = Color.Blue;


            // Title defination
            Label faceTitle = new Label
            {
                Text = "FACE",
                FontSize = Device.OnPlatform(150, 100, 150),
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.Center
            };

            Label emojiTitle = new Label
            {
                Text = "EMOJI",
                FontSize = Device.OnPlatform(150, 100, 150),
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.End,
                VerticalTextAlignment = TextAlignment.Center
            };

            // Body defination which contains two btns
            this.pickButton = new Button
            {
                FontSize = 40,
                FontAttributes = FontAttributes.Italic,
                Text = "Pick!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            this.safariButton = new Button
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

            this.Content = relativeLayout;

            // Btn Delegation Initializing
            pickButton.Clicked += OnPickBtnClicked;
        }

        

        private async void OnPickBtnClicked(object sender, EventArgs args)
        {
            var action = await DisplayActionSheet(
                "Get your photo via?",
                "Cancel",
                null,
                "Album",
                "Camera"
                );
            if(action == "Album"){



            } else if(action == "Camera") {
                MessagingCenter.Send(this,
                    App.NativeNavigationMessage,
                    new NativeNavigationArgs(new PhotoPage())
                   );
            } else { }
            
        }



        private void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            View view = (View) sender;
            //double lineHeight = Device
        }
           
    }
}
