namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void agregar()
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                MessageBox.Show("error", "el nombre esta vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtlibro.Text))
            {
                MessageBox.Show("Escribe un libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    data1.Rows.Add(txtnombre.Text, txtlibro.Text, DateTime.UtcNow, DateTime.UtcNow.AddDays(30));
                    txtnombre.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        public void Eliminar() {

            if (data1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in data1.SelectedRows)
                {
                    data1.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("SELECCIONA UN DATO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();

        }
    }
}