using System.Data;

namespace note_app
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("messages", typeof(string));

            dgvMsg.DataSource = table;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Ocisti();
        }

        private void Ocisti()
        {
            txtTitle.Clear();
            txtNotes.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtNotes.Text);

            Ocisti();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dgvMsg.CurrentCell.RowIndex;

            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtNotes.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvMsg.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }
    }
}