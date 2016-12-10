using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SquareGamesFarid.Resources;
using System.Windows.Media;
using System.Windows.Input;
using System.Windows.Shapes;

namespace SquareGamesFarid
{
    public partial class MainPage : PhoneApplicationPage
    {
        private TranslateTransform Move = new TranslateTransform();
        private TransformGroup RectTransf = new TransformGroup();
        private ScaleTransform Scale = new ScaleTransform();
        private ScaleTransform Resize = new ScaleTransform();
        private Brush StartBrush;
        MyTransporter tr ;

        MyTransporter tr2 ;

        MyTransporter tr3 ;

        MyTransporter tr4 ;

        MyTransporter tr5 ;

        MyTransporter tr6 ;

        MyTransporter tr7 ;

        MyTransporter tr8 ;

        MyTransporter tr9 ;

        MyTransporter tr10 ;

        MyTransporter tr11 ;

        MyTransporter tr12 ;

        MyTransporter tr13 ;

        MyTransporter tr14 ;

        MyTransporter tr15 ;

        private Brush TransBrush = new SolidColorBrush(Color.FromArgb(255, 255, 13, 226));
        // Constructor
        public MainPage()
        {

            InitializeComponent();


            rootCanvas.Width = 400;

            rootCanvas.Height = 400;
            rootCanvas.Background = new SolidColorBrush(Color.FromArgb(255, 134, 13, 226)); ;
            Stt stt = MyTransporter.sdc.getFirstState();


            int dist = 1;
            MyTransporter.setTextBlock(move);
            tr = new MyTransporter(recta, texta, stt.a, 1, 0, 0, rootCanvas);
            tr = giveTransporter(tr, stt.a);

            tr2 = new MyTransporter(rectb, textb, stt.b, 2, 0, 100 * dist, rootCanvas);
            tr2 = giveTransporter(tr2, stt.b);

            tr3 = new MyTransporter(rectc, textc, stt.c, 3, 0, 300 * dist, rootCanvas);
            tr3 = giveTransporter(tr3, stt.c);

            tr4 = new MyTransporter(rectd, textd, stt.d, 4, 100 * dist, 0, rootCanvas);
            tr4 = giveTransporter(tr4, stt.d);

            tr5 = new MyTransporter(recte, texte, stt.e, 5, 100 * dist, 100 * dist, rootCanvas);
            tr5 = giveTransporter(tr5, stt.e);

            tr6 = new MyTransporter(rectf, textf, stt.f, 6, 100 * dist, 200 * dist, rootCanvas);
            tr6 = giveTransporter(tr6, stt.f);

            tr7 = new MyTransporter(rectg, textg, stt.g, 7, 100 * dist, 300 * dist, rootCanvas);
            tr7 = giveTransporter(tr7, stt.g);

            tr8 = new MyTransporter(recth, texth, stt.h, 8, 200 * dist, 0, rootCanvas);
            tr8 = giveTransporter(tr8, stt.h);

            tr9 = new MyTransporter(recti, texti, stt.i, 9, 200 * dist, 100 * dist, rootCanvas);
            tr9 = giveTransporter(tr9, stt.i);

            tr10 = new MyTransporter(rectj, textj, stt.j, 10, 200 * dist, 200 * dist, rootCanvas);
            tr10 = giveTransporter(tr10, stt.j);

            tr11 = new MyTransporter(rectk, textk, stt.k, 11, 200 * dist, 300 * dist, rootCanvas);
            tr11 = giveTransporter(tr11, stt.k);

            tr12 = new MyTransporter(rectl, textl, stt.l, 12, 300 * dist, 0, rootCanvas);
            tr12 = giveTransporter(tr12, stt.l);

            tr13 = new MyTransporter(rectm, textm, stt.m, 13, 300 * dist, 100 * dist, rootCanvas);
            tr13 = giveTransporter(tr13, stt.m);

            tr14 = new MyTransporter(rectn, textn, stt.n, 14, 300 * dist, 200 * dist, rootCanvas);
            tr14 = giveTransporter(tr14, stt.n);

            tr15 = new MyTransporter(recto, texto, stt.o, 15, 300 * dist, 300 * dist, rootCanvas);
            tr15 = giveTransporter(tr15, stt.o);

            MyTransporter.moveCount = stt.move;
            MyTransporter.setEmptyNumber(stt.space);
            move.Text = "" + stt.move;
            //Canvas.SetTop(rectangle, 150);

            //Canvas.SetLeft(rectangle, 150);

            


            

        }



        private void start()
        { }



        private void rect_manDelta(object sender, ManipulationDeltaEventArgs e)
        {
            //Move.X += e.DeltaManipulation.Translation.X;
            //MessageBox.Show(Move.Y + " " + e.DeltaManipulation.Translation.Y);
           
           

            if (e.DeltaManipulation.Scale.X > 0 && e.DeltaManipulation.Scale.Y > 0)
            {
                //Resize.ScaleX *= e.DeltaManipulation.Scale.X;
                //Resize.ScaleY *= e.DeltaManipulation.Scale.Y;
            }
        }

        private void newGame(object sender, RoutedEventArgs e) 
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 16;i++ )
            {
                list.Add(i + 1);
            }
            Random rnd = new Random();

            MyTransporter.moveCount = 0;
            move.Text = ""+0;
            MyTransporter.setTextBlock(move);
            
            

            int y = rnd.Next(0, 16);
            tr3 = giveTransporter(tr3, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 15);
            tr4 = giveTransporter(tr4, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 14);
            tr5 = giveTransporter(tr5, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 13);
            tr6 = giveTransporter(tr6, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 12);
            tr7 = giveTransporter(tr7, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 11);
            tr8 = giveTransporter(tr8, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 10);
            tr9 = giveTransporter(tr9, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 9);
            tr10 = giveTransporter(tr10, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 8);
            tr11 = giveTransporter(tr11, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 7);
            tr12 = giveTransporter(tr12, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 6);
            tr13 = giveTransporter(tr13, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 5);
            tr14 = giveTransporter(tr14, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 4);
            tr15 = giveTransporter(tr15,list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 3);
            tr = giveTransporter(tr, list[y]);
            list.RemoveAt(y);

            y = rnd.Next(0, 2);
            tr2 = giveTransporter(tr2, list[y]);
            list.RemoveAt(y);

            MyTransporter.setEmptyNumber(list[0]);
           // MyTransporter.sdc.UpdateState(1,tr.number, tr2.number, tr3.number, tr4.number, tr5.number, tr6.number, tr7.number, tr8.number, tr9.number, tr10.number, tr11.number, tr12.number, tr13.number, tr14.number, tr15.number, list[0], 0);

        }

        private void Save(object sender, RoutedEventArgs e) 
        {



            MyTransporter.sdc.UpdateState(1, tr.number, tr2.number, tr3.number, tr4.number, tr5.number, tr6.number, tr7.number, tr8.number, tr9.number, tr10.number, tr11.number, tr12.number, tr13.number, tr14.number, tr15.number, MyTransporter.emptyNumber,(int) MyTransporter.moveCount );

        }

        private MyTransporter giveTransporter(MyTransporter mt,int n) 
        {
            mt.setNumber(n);
            if (n == 1) {

                mt.setPosition(0, 0, rootCanvas);
            } 
            else if (n == 2)
            {
                mt.setPosition(0, 100, rootCanvas);
            }
            else if (n == 3)
            {
                mt.setPosition(0, 200, rootCanvas);
            }
            else if (n == 4)
            {
                mt.setPosition(0, 300, rootCanvas);
            }
            else if (n == 5)
            {
                mt.setPosition(100, 0, rootCanvas);
            }
            else if (n == 6)
            {
                mt.setPosition(100, 100, rootCanvas);
            }
            else if (n == 7)
            {
                mt.setPosition(100, 200, rootCanvas);
            }
            else if (n == 8)
            {
                mt.setPosition(100, 300, rootCanvas);
            }
            else if (n == 9)
            {
                mt.setPosition(200, 0, rootCanvas);
            }
            else if (n == 10)
            {
                mt.setPosition(200, 100, rootCanvas);
            }
            else if (n == 11)
            {
                mt.setPosition(200, 200, rootCanvas);
            }
            else if (n == 12)
            {
                mt.setPosition(200, 300, rootCanvas);
            }
            else if (n == 13)
            {
                mt.setPosition(300, 0, rootCanvas);
            }
            else if (n == 14)
            {
                mt.setPosition(300, 100, rootCanvas);
            }
            else if (n == 15)
            {
                mt.setPosition(300, 200, rootCanvas);
            }
            else 
            {
                mt.setPosition(300, 300, rootCanvas);
            }
            return mt;
        }


        private void giveEmpty(int n) 
        {

            if (n == 1)
            {
                MyTransporter.changeEmpty(0, 0);
            }
            else if (n == 2)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 3)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 4)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 5)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 6)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 7)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 8)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 9)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 10)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 11)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 12)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 13)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 14)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else if (n == 15)
            {
                MyTransporter.changeEmpty(100, 0);
            }
            else
            {
                MyTransporter.changeEmpty(100, 0);
            }

        }
       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }



}