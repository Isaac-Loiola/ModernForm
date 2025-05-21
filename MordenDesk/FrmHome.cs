namespace MordenDesk
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flpMenu.Height += 10;
                if (flpMenu.Height >= 190) //largura. botao
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flpMenu.Height -= 10;
                if (flpMenu.Height <= 42) // Altura do botão
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flpSidebar.Width -= 10;
                if (flpSidebar.Width <= 71)
                {
                    sidebarExpand = false;
                    sideBarTransition.Stop();
                }
            }
            else
            {
                flpSidebar.Width += 10;
                // verificando se layout está com a largura normal 
                if (flpSidebar.Width >= 193)
                {
                    sidebarExpand = true;
                    sideBarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }
    }
}
