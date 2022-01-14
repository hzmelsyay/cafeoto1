namespace cafeoto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ComboBox cbKullanici;

        private void Form1_Load(object sender, EventArgs e)
        {
            CPersoneller p = new CPersoneller();
            p.personelGetbyInformation(cbKullanici);
        }

        private void frm1_Click(object sender, EventArgs e)
        {
            Cgenel gnl = new Cgenel();
            CPersoneller p = new CPersoneller();
            bool result = p.personelEntryControl(txtSifre.Text, gnl._PersonelId);
            if (result)
            {
                this.Hide();
                FrmMENU menu = new FrmMENU();
                menu.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            CPersoneller p = (CPersoneller)cbKullanici.SelectedItem;
            gnl._PersonelId = p.PersonelId;
            gnl._gorevId = p.PersonelGorevId;
        }
        
                 
    }

    internal class txtSifre
    {
        internal static object Text;
    }
}