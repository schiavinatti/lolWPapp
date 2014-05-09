using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace lolRespawn
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            #region Interval/Tick

            #region baron

            timerBaron.Interval = new TimeSpan(0, 0, 0, 1);
            timerBaron.Tick += new EventHandler(Baron_Tick);

            #endregion

            #region dragon

            timerDragon.Interval = new TimeSpan(0, 0, 0, 1);
            timerDragon.Tick += new EventHandler(Dragon_Tick);

            #endregion

            #region LizardTop

            timerLizardTop.Interval = new TimeSpan(0, 0, 0, 1);
            timerLizardTop.Tick += new EventHandler(LizardTop_Tick);

            #endregion

            #region LizardBot

            timerLizardBot.Interval = new TimeSpan(0, 0, 0, 1);
            timerLizardBot.Tick += new EventHandler(LizardBot_Tick);

            #endregion

            #region AncientTop

            timerAncientTop.Interval = new TimeSpan(0, 0, 0, 1);
            timerAncientTop.Tick += new EventHandler(AncientTop_Tick);

            #endregion

            #region AncientBot

            timerAncientBot.Interval = new TimeSpan(0, 0, 0, 1);
            timerAncientBot.Tick += new EventHandler(AncientBot_Tick);

            #endregion

            #region GolemTop

            timerGolemTop.Interval = new TimeSpan(0, 0, 0, 1);
            timerGolemTop.Tick += new EventHandler(GolemTop_Tick);

            #endregion

            #region GolemBot

            timerGolemBot.Interval = new TimeSpan(0, 0, 0, 1);
            timerGolemBot.Tick += new EventHandler(GolemBot_Tick);

            #endregion

            #region WolfTop

            timerWolfTop.Interval = new TimeSpan(0, 0, 0, 1);
            timerWolfTop.Tick += new EventHandler(WolfTop_Tick);

            #endregion

            #region WolfBot

            timerWolfBot.Interval = new TimeSpan(0, 0, 0, 1);
            timerWolfBot.Tick += new EventHandler(WolfBot_Tick);

            #endregion

            #region WraithTop

            timerWraithTop.Interval = new TimeSpan(0, 0, 0, 1);
            timerWraithTop.Tick += new EventHandler(WraithTop_Tick);

            #endregion

            #region WraithBot

            timerWraithBot.Interval = new TimeSpan(0, 0, 0, 1);
            timerWraithBot.Tick += new EventHandler(WraithBot_Tick);

            #endregion

            #endregion

            #region zerando tela

            imgBaron.Width = 0;
            imgDragon.Width = 0;
            imgLizardTop.Width = 0;
            imgLizardBot.Width = 0;
            imgAncientTop.Width = 0;
            imgAncientBot.Width = 0;
            imgGolemTop.Width = 0;
            imgGolemBot.Width = 0;
            imgWolfTop.Width = 0;
            imgWolfBot.Width = 0;
            imgWraithTop.Width = 0;
            imgWraithBot.Width = 0;
            imgBaron.Height = 0;
            imgDragon.Height = 0;
            imgLizardTop.Height = 0;
            imgLizardBot.Height = 0;
            imgAncientTop.Height = 0;
            imgAncientBot.Height = 0;
            imgGolemTop.Height = 0;
            imgGolemBot.Height = 0;
            imgWolfTop.Height = 0;
            imgWolfBot.Height = 0;
            imgWraithTop.Height = 0;
            imgWraithBot.Height = 0;

            ClockBaron.Width = 0;
            ClockDragon.Width = 0;
            ClockLizardTop.Width = 0;
            ClockLizardBot.Width = 0;
            ClockAncientTop.Width = 0;
            ClockAncientBot.Width = 0;
            ClockGolemTop.Width = 0;
            ClockGolemBot.Width = 0;
            ClockWolfTop.Width = 0;
            ClockWolfBot.Width = 0;
            ClockWraithTop.Width = 0;
            ClockWraithBot.Width = 0;
            ClockBaron.Height = 0;
            ClockDragon.Height = 0;
            ClockLizardTop.Height = 0;
            ClockLizardBot.Height = 0;
            ClockAncientTop.Height = 0;
            ClockAncientBot.Height = 0;
            ClockGolemTop.Height = 0;
            ClockGolemBot.Height = 0;
            ClockWolfTop.Height = 0;
            ClockWolfBot.Height = 0;
            ClockWraithTop.Height = 0;
            ClockWraithBot.Height = 0;

            #endregion

        }

        #region DispatcherTimer

        DispatcherTimer timerBaron = new DispatcherTimer();
        DispatcherTimer timerDragon = new DispatcherTimer();
        DispatcherTimer timerLizardTop = new DispatcherTimer();
        DispatcherTimer timerLizardBot = new DispatcherTimer();
        DispatcherTimer timerAncientTop = new DispatcherTimer();
        DispatcherTimer timerAncientBot = new DispatcherTimer();
        DispatcherTimer timerGolemTop = new DispatcherTimer();
        DispatcherTimer timerGolemBot = new DispatcherTimer();
        DispatcherTimer timerWolfTop = new DispatcherTimer();
        DispatcherTimer timerWolfBot = new DispatcherTimer();
        DispatcherTimer timerWraithTop = new DispatcherTimer();
        DispatcherTimer timerWraithBot = new DispatcherTimer();

        #endregion

        #region vars

    	int apagar = 10;
		
        int WidthClock = 76;
        int HeightClock = 37;

        int WidthImg = 50;
        int HeightImg = 50;

        bool gameOn = false;
		
/*
        int tikBaron = 65;
        int tikDragon = 360;
        int tikLizardTop = 300;
        int tikLizardBot = 300;
        int tikAncientTop = 15;
        int tikAncientBot = 300;
        int tikGolemTop = 50;
        int tikGolemBot = 50;
        int tikWolfTop = 50;
        int tikWolfBot = 50;
        int tikWraithTop = 50;
        int tikWraithBot = 50;
*/

        #endregion

        #region fuction_tick

        #region Baron
        void Baron_Tick(object sender, EventArgs e)
        {

            ClockBaron.Text = String.Format("{00:00}", tikBaron / 60) + ":" + String.Format("{00:00}", tikBaron % 60);

            if (tikBaron > 0)
                tikBaron--;
            else
            {
                ClockBaron.Width = 0;
                ClockBaron.Height = 0;
                imgBaron.Width = WidthImg;
                imgBaron.Height = HeightImg;
            }

        }
        #endregion

        #region dragon
        void Dragon_Tick(object sender, EventArgs e)
        {

            ClockDragon.Text = String.Format("{00:00}", tikDragon / 60) + ":" + String.Format("{00:00}", tikDragon % 60);
            if (tikDragon > 0)
                tikDragon--;
            else
            {
                ClockDragon.Width = 0;
                ClockDragon.Height = 0;
                imgDragon.Width = WidthImg;
                imgDragon.Height = HeightImg;
            }
        }
        #endregion

        #region Lizards
        void LizardTop_Tick(object sender, EventArgs e)
        {

            ClockLizardTop.Text = String.Format("{00:00}", tikLizardTop / 60) + ":" + String.Format("{00:00}", tikLizardTop % 60);
            if (tikLizardTop > 0)
                tikLizardTop--;
            else
            {
                ClockLizardTop.Width = 0;
                ClockLizardTop.Height = 0;
                imgLizardTop.Width = WidthImg;
                imgLizardTop.Height = HeightImg;
            }
        }

        void LizardBot_Tick(object sender, EventArgs e)
        {

            ClockLizardBot.Text = String.Format("{00:00}", tikLizardBot / 60) + ":" + String.Format("{00:00}", tikLizardBot % 60);
            if (tikLizardBot > 0)
                tikLizardBot--;
            else
            {
                ClockLizardBot.Width = 0;
                ClockLizardBot.Height = 0;
                imgLizardBot.Width = WidthImg;
                imgLizardBot.Height = HeightImg;
            }

        }
        #endregion

        #region Ancients
        void AncientTop_Tick(object sender, EventArgs e)
        {

            ClockAncientTop.Text = String.Format("{00:00}", tikAncientTop / 60) + ":" + String.Format("{00:00}", tikAncientTop % 60);
            if (tikAncientTop > 0)
                tikAncientTop--;
            else
            {
                ClockAncientTop.Width = 0;
                ClockAncientTop.Height = 0;
                imgAncientTop.Width = WidthImg;
                imgAncientTop.Height = HeightImg;
            }
        }
        void AncientBot_Tick(object sender, EventArgs e)
        {

            ClockAncientBot.Text = String.Format("{00:00}", tikAncientBot / 60) + ":" + String.Format("{00:00}", tikAncientBot % 60);
            if (tikAncientBot > 0)
                tikAncientBot--;
            else
            {
                ClockAncientBot.Width = 0;
                ClockAncientBot.Height = 0;
                imgAncientBot.Width = WidthImg;
                imgAncientBot.Height = HeightImg;
            }
        }
        #endregion

        #region Golens
        void GolemTop_Tick(object sender, EventArgs e)
        {

            ClockGolemTop.Text = String.Format("{00:00}", tikGolemTop / 60) + ":" + String.Format("{00:00}", tikGolemTop % 60);
            if (tikGolemTop > 0)
                tikGolemTop--;
            else
            {
                ClockGolemTop.Width = 0;
                ClockGolemTop.Height = 0;
                imgGolemTop.Width = WidthImg;
                imgGolemTop.Height = HeightImg;
            }
        }
        void GolemBot_Tick(object sender, EventArgs e)
        {

            ClockGolemBot.Text = String.Format("{00:00}", tikGolemBot / 60) + ":" + String.Format("{00:00}", tikGolemBot % 60);
            if (tikGolemBot > 0)
                tikGolemBot--;
            else
            {
                ClockGolemBot.Width = 0;
                ClockGolemBot.Height = 0;
                imgGolemBot.Width = WidthImg;
                imgGolemBot.Height = HeightImg;
            }

        }
        #endregion

        #region Wolfs
        void WolfTop_Tick(object sender, EventArgs e)
        {

            ClockWolfTop.Text = String.Format("{00:00}", tikWolfTop / 60) + ":" + String.Format("{00:00}", tikWolfTop % 60);
            if (tikWolfTop > 0)
                tikWolfTop--;
            else
            {
                ClockWolfTop.Width = 0;
                ClockWolfTop.Height = 0;
                imgWolfTop.Width = WidthImg;
                imgWolfTop.Height = HeightImg;
            }
        }

        void WolfBot_Tick(object sender, EventArgs e)
        {

            ClockWolfBot.Text = String.Format("{00:00}", tikWolfBot / 60) + ":" + String.Format("{00:00}", tikWolfBot % 60);
            if (tikWolfBot > 0)
                tikWolfBot--;
            else
            {
                ClockWolfBot.Width = 0;
                ClockWolfBot.Height = 0;
                imgWolfBot.Width = WidthImg;
                imgWolfBot.Height = HeightImg;
            }
        }
        #endregion

        #region Wraiths
        void WraithTop_Tick(object sender, EventArgs e)
        {

            ClockWraithTop.Text = String.Format("{00:00}", tikWraithTop / 60) + ":" + String.Format("{00:00}", tikWraithTop % 60);
            if (tikWraithTop > 0)
                tikWraithTop--;
            else
            {
                ClockWraithTop.Width = 0;
                ClockWraithTop.Height = 0;
                imgWraithTop.Width = WidthImg;
                imgWraithTop.Height = HeightImg;
            }
        }

        void WraithBot_Tick(object sender, EventArgs e)
        {

            ClockWraithBot.Text = String.Format("{00:00}", tikWraithBot / 60) + ":" + String.Format("{00:00}", tikWraithBot % 60);
            if (tikWraithBot > 0)
                tikWraithBot--;
            else
            {
                ClockWraithBot.Width = 0;
                ClockWraithBot.Height = 0;
                imgWraithBot.Width = WidthImg;
                imgWraithBot.Height = HeightImg;
            }
        }

        #endregion

        #endregion

        #region function_start

        #region baron

        private void startBaron()
        {
            if (gameOn)
            {
                tikBaron = 420/apagar;
            }
            ClockBaron.Height = HeightClock;
            ClockBaron.Width = WidthClock;
            timerBaron.Start();
            imgBaron.Width = 0;
            imgBaron.Height = 0;
        }

        #endregion

        #region dragon

        private void startDragon()
        {
            if (gameOn)
            {
                tikDragon = 360/apagar;
            }
            ClockDragon.Height = HeightClock;
            ClockDragon.Width = WidthClock;
            timerDragon.Start();
            imgDragon.Width = 0;
            imgDragon.Height = 0;
        }

        #endregion

        #region lizardTop

        private void startLizardTop()
        {
            if (gameOn)
            {
                tikLizardTop = 300/apagar;
            }
            ClockLizardTop.Height = HeightClock;
            ClockLizardTop.Width = WidthClock;
            timerLizardTop.Start();
            imgLizardTop.Width = 0;
            imgLizardTop.Height = 0;
        }

        #endregion

        #region lizardBot

        private void startLizardBot()
        {
            if (gameOn)
            {
                tikLizardBot = 300/apagar;
            }
            ClockLizardBot.Height = HeightClock;
            ClockLizardBot.Width = WidthClock;
            timerLizardBot.Start();
            imgLizardBot.Width = 0;
            imgLizardBot.Height = 0;
        }

        #endregion

        #region AncientTop

        private void startAncientTop()
        {
            if (gameOn)
            {
                tikAncientTop = 300/apagar;
            }
            ClockAncientTop.Height = HeightClock;
            ClockAncientTop.Width = WidthClock;
            timerAncientTop.Start();
            imgAncientTop.Width = 0;
            imgAncientTop.Height = 0;
        }

        #endregion

        #region AncientBot

        private void startAncientBot()
        {
            if (gameOn)
            {
                tikAncientBot = 300/apagar;
            }
            ClockAncientBot.Height = HeightClock;
            ClockAncientBot.Width = WidthClock;
            timerAncientBot.Start();
            imgAncientBot.Width = 0;
            imgAncientBot.Height = 0;
        }

        #endregion

        #region golemTop

        private void startGolemTop()
        {
            if (gameOn)
            {
                tikGolemTop = 50/apagar;
            }
            ClockGolemTop.Height = HeightClock;
            ClockGolemTop.Width = WidthClock;
            timerGolemTop.Start();
            imgGolemTop.Width = 0;
            imgGolemTop.Height = 0;
        }

        #endregion

        #region golemBot

        private void startGolemBot()
        {
            if (gameOn)
            {
                tikGolemBot = 50/apagar;
            }
            ClockGolemBot.Height = HeightClock;
            ClockGolemBot.Width = WidthClock;
            timerGolemBot.Start();
            imgGolemBot.Width = 0;
            imgGolemBot.Height = 0;
        }

        #endregion

        #region WolfTop

        private void startWolfTop()
        {
            if (gameOn)
            {
                tikWolfTop = 50/apagar;
            }
            ClockWolfTop.Height = HeightClock;
            ClockWolfTop.Width = WidthClock;
            timerWolfTop.Start();
            imgWolfTop.Width = 0;
            imgWolfTop.Height = 0;
        }

        #endregion

        #region WolfBot

        private void startWolfBot()
        {
            if (gameOn)
            {
                tikWolfBot = 50/apagar;
            }
            ClockWolfBot.Height = HeightClock;
            ClockWolfBot.Width = WidthClock;
            timerWolfBot.Start();
            imgWolfBot.Width = 0;
            imgWolfBot.Height = 0;
        }

        #endregion

        #region WraithTop

        private void startWraithTop()
        {
            if (gameOn)
            {
                tikWraithTop = 50/apagar;
            }
            ClockWraithTop.Height = HeightClock;
            ClockWraithTop.Width = WidthClock;
            timerWraithTop.Start();
            imgWraithTop.Width = 0;
            imgWraithTop.Height = 0;
        }

        #endregion

        #region WraithBot

        private void startWraithBot()
        {
            if (gameOn)
            {
                tikWraithBot = 50/apagar;
            }
            ClockWraithBot.Height = HeightClock;
            ClockWraithBot.Width = WidthClock;
            timerWraithBot.Start();
            imgWraithBot.Width = 0;
            imgWraithBot.Height = 0;
        }

        #endregion

        #endregion

        #region private void img_DoubleTap

        #region Baron

        private void imgBaron_DoubleTap(object sender, GestureEventArgs e)
        {
            startBaron();
        }

        #endregion

        #region Dragon

        private void imgDragon_DoubleTap(object sender, GestureEventArgs e)
        {
            startDragon();
        }

        #endregion

        #region LizardTop

        private void imgLizardTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startLizardTop();
        }

        #endregion

        #region LizardBot

        private void imgLizardBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startLizardBot();
        }

        #endregion

        #region AncientTop

        private void imgAncientTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startAncientTop();
        }

        #endregion

        #region AncientBot

        private void imgAncientBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startAncientBot();
        }

        #endregion

        #region GolemTop

        private void imgGolemTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startGolemTop();
        }

        #endregion

        #region GolemBot

        private void imgGolemBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startGolemBot();
        }

        #endregion

        #region WolfTop

        private void imgWolfTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startWolfTop();
        }

        #endregion

        #region WolfBot

        private void imgWolfBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startWolfBot();
        }

        #endregion

        #region WraithTop

        private void imgWraithTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startWraithTop();
        }

        #endregion

        #region WraithBot

        private void imgWraithBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startWraithBot();
        }

        #endregion

        #endregion

        #region private void Clock_DoubleTap

        #region Baron

        private void ClockBaron_DoubleTap(object sender, GestureEventArgs e)
        {
            startBaron();
        }

        #endregion

        #region Dragon

        private void ClockDragon_DoubleTap(object sender, GestureEventArgs e)
        {
            startDragon();
        }

        #endregion

        #region LizardTop

        private void ClockLizardTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startLizardTop();
        }

        #endregion

        #region LizardBot

        private void ClockLizardBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startLizardBot();
        }

        #endregion

        #region AncientTop

        private void ClockAncientTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startAncientTop();
        }

        #endregion

        #region AncientBot

        private void ClockAncientBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startAncientBot();
        }

        #endregion

        #region GolemTop

        private void ClockGolemTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startGolemTop();
        }

        #endregion

        #region GolemBot

        private void ClockGolemBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startGolemBot();
        }

        #endregion

        #region WolfTop

        private void ClockWolfTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startWolfTop();
        }

        #endregion

        #region WolfBot

        private void ClockWolfBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startWolfBot();
        }

        #endregion

        #region WraithTop

        private void ClockWraithTop_DoubleTap(object sender, GestureEventArgs e)
        {
            startWraithTop();
        }

        #endregion

        #region WraithBot

        private void ClockWraithBot_DoubleTap(object sender, GestureEventArgs e)
        {
            startWraithBot();
        }

        #endregion

        #endregion

        private void Image_DoubleTap(object sender, GestureEventArgs e)
        {

            gameOn = false;

            tikBaron = 900/apagar;
            tikDragon = 150/apagar;
            tikLizardTop = 115/apagar;
            tikLizardBot = 115/apagar;
            tikAncientTop = 115/apagar;
            tikAncientBot = 115/apagar;
            tikGolemTop = 125/apagar;
            tikGolemBot = 125/apagar;
            tikWolfTop = 125/apagar;
            tikWolfBot = 125/apagar;
            tikWraithTop = 125/apagar;
            tikWraithBot = 125/apagar;

            startBaron();
            startDragon();
            startLizardTop();
            startLizardBot();
            startAncientTop();
            startAncientBot();
            startGolemTop();
            startGolemBot();
            startWolfTop();
            startWolfBot();
            startWraithTop();
            startWraithBot();

            gameOn = true;
        }

    }
}
