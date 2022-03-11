using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp {
    public partial class MainPage : ContentPage {
        public MainPage() {
            Button button = new Button {
                Text = "Привет",
                CornerRadius = 10,
                WidthRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
            };

            StackLayout layout = new StackLayout {
                Children = {
                    new Label {
                        Text = "Hello world!",
                        FontFamily = "Arial",
                        FontSize = 40,
                        HorizontalOptions = LayoutOptions.Center,
                    },
                    button,
                }
            };
            
            button.Clicked += ButtonClicked;
            this.Content = layout;
        }
        
        bool acs = true;
        private void ButtonClicked(object sender, EventArgs e) {
            if (acs) {
                (sender as Button).Text = "Опа, нажал";
                acs = false;
            } else {
                (sender as Button).Text = "Опа, обратно";
                acs = true;
            }
            
        }
    }
}
