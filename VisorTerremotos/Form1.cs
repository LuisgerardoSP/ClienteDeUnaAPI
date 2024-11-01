namespace VisorTerremotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var api = new ApiClient();
            var listaFeatures = await api.GetRoot(Convert.ToInt32(nu1.Value));
            int idColumna = 1;
            foreach (var it in listaFeatures.Features)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    idColumna ++, 
                    it.Properties.Mag,
                    it.Properties.Place,
                    it.Properties.Time,
                    it.Properties.Updated,
                    it.Properties.Tz,
                    it.Properties.Url,
                    it.Properties.Detail,
                    it.Properties.Felt,
                    it.Properties.Cdi,
                    it.Properties.Mmi,
                    it.Properties.Alert,
                    it.Properties.Status,
                    it.Properties.Tsunami,
                    it.Properties.Sig,
                    it.Properties.Net,
                    it.Properties.Code,
                    it.Properties.Ids,
                    it.Properties.Sources,
                    it.Properties.Types,
                    it.Properties.Nst,
                    it.Properties.Dmin,
                    it.Properties.Rms,
                    it.Properties.Gap,
                    it.Properties.MagType,
                    it.Properties.Type,
                    it.Properties.Title
                });
            }
            
        }
    }
}
