using PortugalVisaSEFCheckerTraySystem.Properties;
using System;
using System.Windows.Forms;

namespace PortugalVisaSEFCheckerTraySystem
{
    class ProcessIcon : IDisposable
	{
		NotifyIcon ni;

        int interval;

        public ProcessIcon()
		{
			ni = new NotifyIcon();

            interval = 1000 * 60 * Settings.Default.interval;
        }

		/// <summary>
		/// Displays the icon in the system tray.
		/// </summary>
		public void Display()
		{
			// Put the icon in the system tray and allow it react to mouse clicks.			
			ni.MouseClick += new MouseEventHandler(ni_MouseClick);
			ni.Icon = Resources.PT;
			ni.Text = "Portugal Visa SEF Checker";
			ni.Visible = true;

			// Attach a context menu.
			ni.ContextMenuStrip = new ContextMenus().Create();           
		}

        public void RunScheduler()
        {
            Timer checkForTime = new Timer();
            checkForTime.Interval = interval;
            checkForTime.Tick+= new EventHandler(MyTimer_Tick);
            checkForTime.Start();

            Global.Interval = Settings.Default.interval;
            Global.NextExecution = DateTime.Now.AddMinutes(Global.Interval);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {   
            CheckStatus();            
            Global.NextExecution = DateTime.Now.AddMinutes(Global.Interval);
        }

        public void CheckStatus()
        {
            ni.Icon = Resources.PT;
            Global.LastResult = HttpChecker.Do();
            ChangeIcon(Global.LastResult.ToLower().Trim());
            Global.LastExecution = DateTime.Now;
        }

        private void ChangeIcon(string state)
        {
            switch (state)
            {
                case "aceite":
                    ni.Icon = Resources.Aceite;
                    break;
                case "em análise":
                    ni.Icon = Resources.Em_Analise;
                    break;
                case "analisado":
                    ni.Icon = Resources.Analisado;
                    break;
                case "concluído":
                    ni.Icon = Resources.Concluido;
                    break;
                case "erro":
                    ni.Icon = Resources.Interrogacao;
                    break;
                default:
                    ni.Icon = Resources.Interrogacao;
                    break;
            }
        }

        public void Dispose()
		{
			// When the application closes, this will remove the icon from the system tray immediately.
			ni.Dispose();
		}

		void ni_MouseClick(object sender, MouseEventArgs e)
		{
            // Event to handle mouse click
		}
	}
}
