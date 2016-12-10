using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    class MyTransporter
    {
        private Rectangle rectangle = new Rectangle();
        private TextBlock textblock = new TextBlock();
        private TranslateTransform Move = new TranslateTransform();
        private TransformGroup RectTransf = new TransformGroup();
        private ScaleTransform Scale = new ScaleTransform();
        private ScaleTransform Resize = new ScaleTransform();
        private Brush StartBrush;
        private Brush TransBrush;

        private bool righBlock = false;
        private bool leftBlock = false;
        private bool topBlock = false;
        private bool bottomBlock = false;
        public static double moveCount=0;
        public static double emptyX;
        public static double emptyY;
        public static int emptyNumber;
        public static StateDataContext sdc = new StateDataContext(StateDataContext.DBConnectionString); 
        public int number;
        public static TextBlock mover;
        public int name;

        public static void changeEmpty(double  y,double  x )  
        {
            emptyX = x;
            emptyY = y;
            
        }
        public static void addMove()
        {
            moveCount++;
            mover.Text = moveCount.ToString();

        }
        public static void setTextBlock(TextBlock tb)
        {
            mover=tb;


        }

        public MyTransporter(Rectangle rect, TextBlock tb, int n, int name, int top, int left, Canvas cv) 
        {
            this.name = name;
            this.textblock = tb;
            this.rectangle = rect;
            this.TransBrush = new SolidColorBrush(Color.FromArgb(getRandom(), getRandom(), getRandom(), 9)); ;
            this.rectangle.Height = 100;
            this.rectangle.Width = 100;
            RectTransf.Children.Add(Move);
            RectTransf.Children.Add(Scale);
            RectTransf.Children.Add(Resize);
            RectTransf.Children.Add(Scale);
            this.rectangle.RenderTransform = RectTransf;
            

            this.textblock.RenderTransform = RectTransf;
            this.textblock.Text="";
            //rectangle.Fill = TransBrush;
            this.rectangle.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(rect_manDelta);
            this.rectangle.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(rect_manstart);
            this.rectangle.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(rect_manend);
            this.textblock.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(rect_manDelta);
           // this.textblock.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(text_manstart);
           // this.textblock.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(text_manend);
            this.number = n;
            double dist = 1;
            Canvas.SetZIndex(this.rectangle,16-number);
            //
            this.textblock.Width = 150;
            this.textblock.Height = 150;

            rectangle.Margin = new Thickness(left, top, 0, 0);
            textblock.Margin = new Thickness(left , top , 0, 0);
            //cv.Children.Add(this.rectangle);
           // cv.Children.Add(this.textblock);
            
        }

        public byte getRandom()
        {
            Random random = new Random();
            int i = 255 * (random.Next(155, 255));
            return (byte) i;
            //return 199;
        }

        public void setPosition(int top, int left , Canvas cv){
            Canvas.SetTop(this.rectangle, 0);
            Canvas.SetLeft(this.rectangle, 0);
            Move.X = 0;
            Move.Y = 0;
            //Canvas.SetTop(this.textblock, top + 230);
            //Canvas.SetLeft(this.textblock, left + 250);
            rectangle.Margin = new Thickness(left, top, 0, 0);
            textblock.Margin = new Thickness(left, top, 0, 0);
            //cv.Children.Add(this.rectangle);
            //cv.Children.Add(this.textblock);
        }

        public static void setEmptyNumber(int n){
            
            //changeEmpty((n / 4 ) * 100, (n % 4 ) * 100);
            emptyNumber = n;
         }

        public void setNumber(int n)
        {
            this.number = n;
            //this.setPosition((n / 4 ) * 100, (n % 4) * 100,cv);
        }

        private void text_manstart(object sender, ManipulationStartedEventArgs s)
        {
            this.textblock.Width = 50;
            this.textblock.Height = 50;
        }

        private void rect_manstart(object sender, ManipulationStartedEventArgs s)
        {
            StartBrush = rectangle.Fill;
            Brush tBrush = new SolidColorBrush(Color.FromArgb(getRandom(), getRandom(), getRandom(), getRandom())); ;
            //rectangle.Fill = tBrush;

            // MessageBox.Show(number + "  " + MyTransporter.emptyNumber);
        }
        private void rect_manend(object sender, ManipulationCompletedEventArgs s)
        {
            Brush tBrush = new SolidColorBrush(Color.FromArgb(getRandom(), getRandom(), getRandom(), getRandom())); ;
            rectangle.Fill = StartBrush;
           
            //MyTransporter.sdc.UpdateStateA(1,number,name,emptyNumber,(int) MyTransporter.moveCount); 
            
        }
        private void text_manend(object sender, ManipulationCompletedEventArgs s)
        {
            this.textblock.Width = 400;
            this.textblock.Height = 400;

        }





        private void rect_manDelta(object sender, ManipulationDeltaEventArgs e)
        {
            //MessageBox.Show(number + "  " + MyTransporter.emptyNumber);
            //if ((number - 4) == MyTransporter.emptyNumber)
            if ((number + 4) == MyTransporter.emptyNumber&& e.DeltaManipulation.Translation.X < e.DeltaManipulation.Translation.Y)
            {
                double cx = MyTransporter.emptyX;
                double cy = MyTransporter.emptyY;
                int cn = MyTransporter.emptyNumber; 
                MyTransporter.changeEmpty(Move.X, Move.Y);
                MyTransporter.setEmptyNumber(number);
                Move.Y = Move.Y + 100;
                number = cn;
                MyTransporter.addMove();
            }
            else if ((number + 1) == MyTransporter.emptyNumber && e.DeltaManipulation.Translation.X > e.DeltaManipulation.Translation.Y)
            {
                double cx = MyTransporter.emptyX;
                double cy = MyTransporter.emptyY;
                int cn = MyTransporter.emptyNumber;
                MyTransporter.changeEmpty(Move.X, Move.Y);
                MyTransporter.setEmptyNumber(number);
                //Move.X = cx;
                Move.X = Move.X + 100;
                //Move.Y = cy;
                number = cn;
                MyTransporter.addMove();

            }
            else if ((number - 4) == MyTransporter.emptyNumber && e.DeltaManipulation.Translation.X > e.DeltaManipulation.Translation.Y)
            {
                double cx = MyTransporter.emptyX;
                double cy = MyTransporter.emptyY;
                int cn = MyTransporter.emptyNumber;
                MyTransporter.changeEmpty(Move.X, Move.Y);
                MyTransporter.setEmptyNumber(number);
                Move.Y = Move.Y - 100;
                number = cn;
                MyTransporter.addMove();

            }
            else if ((number -1) == MyTransporter.emptyNumber  && e.DeltaManipulation.Translation.X < e.DeltaManipulation.Translation.Y)
            {
                double cx = MyTransporter.emptyX;
                double cy = MyTransporter.emptyY;
                int cn = MyTransporter.emptyNumber;
                MyTransporter.changeEmpty(Move.X, Move.Y);
                MyTransporter.setEmptyNumber(number);
                //Move.X = cx;
                Move.X = Move.X - 100;
                //Move.Y = cy;
                number = cn;
                MyTransporter.addMove();

            };


            if (e.DeltaManipulation.Scale.X > 0 && e.DeltaManipulation.Scale.Y > 0)
            {
                //Resize.ScaleX *= e.DeltaManipulation.Scale.X;
                //Resize.ScaleY *= e.DeltaManipulation.Scale.Y;
            }
        }
    }
}