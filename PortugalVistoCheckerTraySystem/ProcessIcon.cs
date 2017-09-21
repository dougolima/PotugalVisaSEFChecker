using PortugalVistoCheckerTraySystem.Properties;
using System;
using System.Windows.Forms;

namespace PortugalVistoCheckerTraySystem
{
    class ProcessIcon : IDisposable
	{
		/// <summary>
		/// The NotifyIcon object.
		/// </summary>
		NotifyIcon ni;

        int minutesInterval = 60;

        int interval =  60 * 1000; // milliseconds to one hour

        /// <summary>
		/// Initializes a new instance of the <see cref="ProcessIcon"/> class.
		/// </summary>
		public ProcessIcon()
		{
			// Instantiate the NotifyIcon object.
			ni = new NotifyIcon();

            interval = interval * minutesInterval;
        }

		/// <summary>
		/// Displays the icon in the system tray.
		/// </summary>
		public void Display()
		{
			// Put the icon in the system tray and allow it react to mouse clicks.			
			ni.MouseClick += new MouseEventHandler(ni_MouseClick);
			ni.Icon = Resources.PT;
			ni.Text = "Portugal Visto Checker";
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

            Global.Interval = minutesInterval;
            Global.NextExecution = DateTime.Now.AddMinutes(minutesInterval);
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {   
            CheckStatus();
            Global.LastExecution = DateTime.Now;
            Global.NextExecution = DateTime.Now.AddMinutes(minutesInterval);
        }

        public void CheckStatus()
        {
            ni.Icon = Resources.PT;
            Global.LastResult = VistoChecker.Do();
            ChangeIcon(Global.LastResult.ToLower().Trim());
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

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        public void Dispose()
		{
			// When the application closes, this will remove the icon from the system tray immediately.
			ni.Dispose();
		}

		/// <summary>
		/// Handles the MouseClick event of the ni control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
		void ni_MouseClick(object sender, MouseEventArgs e)
		{
                        
		}
	}
}
