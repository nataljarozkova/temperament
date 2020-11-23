using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace temperament
{
    public partial class MainPage : CarouselPage
    {
        private object Children;

        public MainPage()
        {
            {
                Button btn;
                Uri ur;
                {

                    btn = new Button { Text = "Пройти тест", BackgroundColor = Color.LightBlue, HorizontalOptions = LayoutOptions.Center };
                    Button btn1 = new Button { Text = "Пройти тест", BackgroundColor = Color.LightBlue, HorizontalOptions = LayoutOptions.Center };
                    Button btn2 = new Button { Text = "Пройти тест", BackgroundColor = Color.LightBlue, HorizontalOptions = LayoutOptions.Center };
                    Button btn3 = new Button { Text = "Пройти тест", BackgroundColor = Color.LightBlue, HorizontalOptions = LayoutOptions.Center };

                    btn.Clicked += Btn_Clicked;
                    btn1.Clicked += Btn1_Clicked;
                    btn2.Clicked += Btn2_Clicked; btn3.Clicked += Btn3_Clicked;

                    var holerikcontentpage = new ContentPage
                    {

                        Content = new StackLayout
                        {

                            Children =
                    {
                        new Label{Text="Холерик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        new Image{Source = "hol.jpg", },
                        new Label{Text="Холерик — быстрый, страстный, порывистый, однако совершенно неуравновешенный, с резко меняющимся настроением с эмоциональными вспышками, быстро истощаемый. У него нет равновесия нервных процессов, это его резко отличает от сангвиника. Холерик, увлекаясь, безалаберно растрачивает свои силы и быстро истощается."},

                        btn, }


                        }

                    };
                    var flegmatikcontentpage = new ContentPage
                    {
                        Content = new StackLayout
                        {
                            Children =
                    {
                        new Label{Text="Флегматик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        new Image{Source = "fle.jpg", },
                        new Label{Text="Флегматик неспешен, невозмутим, имеет устойчивые стремления и настроение, внешне скуп на проявление эмоций и чувств. Он проявляет упорство и настойчивость в работе, оставаясь спокойным и уравновешенным. В работе он производителен, компенсируя свою неспешность прилежанием."},

                        
                    }
                        }
                    };
                    var sangvinikcontentpage = new ContentPage
                    {
                        Content = new StackLayout
                        {
                            Children =
                    {
                        new Label{Text="Сангвиник", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                        new Image{Source = "san.jpg",},
                        new Label{Text="Сангвиник — живой, горячий, подвижный человек, с частой сменой настроения, впечатлений, с быстрой реакцией на все события, происходящие вокруг него, довольно легко примиряющийся со своими неудачами и неприятностями. Обычно сангвиники обладают выразительной мимикой. Он очень продуктивен в работе, когда ему интересно, приходя в сильное возбуждение от этого, если работа не интересна, он относится к ней безразлично, ему становится скучно."},


                        btn2
                    }
                        }
                    };
                    var melanholikcontentpage = new ContentPage
                    {
                        Content = new StackLayout
                        {
                            Children =
                    {
                       new Label{Text="Меланхолик", BackgroundColor= Color.Cornsilk, HorizontalTextAlignment= TextAlignment.Center, FontSize=20},
                       new Image{Source = "mel.JPG", },
                       new Label{Text="Меланхолик — человек легко ранимый, склонный к постоянному переживанию различных событий, он мало реагирует на внешние факторы. Свои астенические переживания он не может сдерживать усилием воли, он чересчур впечатлителен, легко эмоционально раним."},

                        btn3
                }
                        }
                    };

                    Children.Add(melanholikcontentpage);
                    Children.Add(flegmatikcontentpage);
                    Children.Add(holerikcontentpage);
                    Children.Add(sangvinikcontentpage);
                }

                private async void Btn3_Clicked(object sender, EventArgs e)
                {
                    ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
                    await Browser.OpenAsync(ur);
                }

                private async void Btn2_Clicked(object sender, EventArgs e)
                {
                    ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
                    await Browser.OpenAsync(ur);
                }

                private async void Btn1_Clicked(object sender, EventArgs e)
                {
                    ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
                    await Browser.OpenAsync(ur);
                }

                private async void Btn_Clicked(object sender, EventArgs e)
                {
                    ur = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
                    await Browser.OpenAsync(ur);
                }
                
                }
            }
        }
}