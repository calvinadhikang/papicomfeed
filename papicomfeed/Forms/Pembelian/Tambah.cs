using MySql.Data.MySqlClient;
using papicomfeed.Database;
using papicomfeed.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace papicomfeed.Forms.Pembelian
{
    public partial class Tambah : Form
    {

        MySqlCommand cmd;
        MySqlDataReader reader;

        DataTable dt;
        DataTable dtIkan;
        DataTable dtKolam;

        int selectedIkanIndex = -1;
        int selectedKolamIndex = -1;

        int total = 0;
        string coba = "anjay" ;

        public Tambah()
        {
            InitializeComponent();
            isicmbIkan();
            isicmbKolam();
            siap2();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans = null;

            try
            {
                trans = DB.conn.BeginTransaction();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = DB.conn;
                cmd.Transaction = trans;

                //insert header
                cmd.CommandText = $"INSERT INTO HBELI (KARYAWAN_ID, TOTAL, PENJUAL, ALAMAT) VALUES ({Form1.idKaryawan}, {total}, '{txtNamaSup.Text}', '{txtAlamatSup.Text}')";
                cmd.ExecuteNonQuery();
                int headerId = Convert.ToInt32(cmd.LastInsertedId);

                //insert detail
                foreach (DataRow item in dt.Rows)
                {
                    int ikanId = int.Parse(item[5].ToString());
                    int qty = int.Parse(item[1].ToString());
                    int harga = int.Parse(item[3].ToString());
                    int subtotal = int.Parse(item[4].ToString());
                    int kolamid = int.Parse(item[6].ToString());
                    string namaIkan = item[0].ToString();
                    

                    cmd.CommandText = $"INSERT INTO DBELI (HBELI_ID, KOLAM_ID, IKAN_ID, HARGA, JUMLAH, NAMA_IKAN, SUBTOTAL) VALUES ({headerId},{kolamid}, {ikanId}, {harga}, {qty}, '{namaIkan}', {subtotal})";
                    cmd.ExecuteNonQuery();
                }

                trans.Commit();
                MessageBox.Show($"Berhasil Insert Penmbelian di supplier {txtNamaSup.Text}");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                trans.Rollback();
            }
        }

        public void isicmbIkan()
        {
            cmbIkan.Items.Clear();
            try
            {
                dtIkan = Ikan.getAll();
                Dictionary<int, string> cmbIkanSource = new Dictionary<int, string>();

                int i = 0;
                foreach (DataRow row in dtIkan.Rows)
                {
                    cmbIkanSource.Add(i, row[1].ToString());
                    i++;
                }

                cmbIkan.DataSource = new BindingSource(cmbIkanSource, null);
                cmbIkan.DisplayMember = "Value";
                cmbIkan.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        public void isicmbKolam()
        {
            cmbKolam.Items.Clear();
            try
            {
                dtKolam = Kolam.getAll();
                Dictionary<int, string> cmbKolamSource = new Dictionary<int, string>();

                int i = 0;
                foreach (DataRow row in dtKolam.Rows)
                {
                    cmbKolamSource.Add(i, row[1].ToString());
                    i++;
                }

                cmbKolam.DataSource = new BindingSource(cmbKolamSource, null);
                cmbKolam.DisplayMember = "Value";
                cmbKolam.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " ");
            }
        }

        public void siap2()
        {
            dt = new DataTable();
            dgvPembelian.DataSource = dt;
         
            dt.Columns.Add("Ikan");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Kolam");
            dt.Columns.Add("Harga");
            dt.Columns.Add("SubTotal");
            dt.Columns.Add("idIkan");
            dt.Columns.Add("idKolam");

            //tambah button tambah
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn();
            btnAdd.Name = "Tambah";
            btnAdd.Text = "+";
            btnAdd.UseColumnTextForButtonValue = true;
            if (dgvPembelian.Columns["Tambah"] == null)
            {
                dgvPembelian.Columns.Insert(7, btnAdd);
                //5 adalah columnIndex
            }
            //tambah button kurangi
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn();
            btnRemove.Name = "Kurangi";
            btnRemove.Text = "-";
            btnRemove.UseColumnTextForButtonValue = true;
            if (dgvPembelian.Columns["Kurangi"] == null)
            {
                dgvPembelian.Columns.Insert(8, btnRemove);
                //6 adalah columnIndex
            }
        }

        private void dgvPembelian_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int oldQty = int.Parse(dt.Rows[row][1].ToString());

            if (e.ColumnIndex == 0 && row > -1)
            {
                //lakukan tambah qty
                oldQty += 1;
            }
            else
            {
                //lakukan pengurangan qty
                oldQty -= 1;
                //kalau qty = 0
                if (oldQty == 0)
                {
                    dt.Rows.RemoveAt(row);
                    countTotal();
                    return;
                }
            }

            int harga = int.Parse(dt.Rows[row][3].ToString());
            int subtotal = oldQty * harga;

            //set value baru
            dt.Rows[row][1] = oldQty;
            dt.Rows[row][4] = subtotal;
            countTotal();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (selectedIkanIndex != -1 || selectedKolamIndex != -1)
            {
                int id = int.Parse(dtIkan.Rows[selectedIkanIndex][0].ToString());
                int idkolam = int.Parse(dtKolam.Rows[selectedKolamIndex][0].ToString());
                string nama = dtIkan.Rows[selectedIkanIndex][1].ToString();
                int qty = int.Parse(numJumlahIkan.Value.ToString());
                int harga = int.Parse(dtIkan.Rows[selectedIkanIndex][3].ToString());
                int subtotal = qty * harga;

                string kolam = dtKolam.Rows[selectedKolamIndex][1].ToString();
                

                if (qty <= 0)
                {
                    MessageBox.Show("QTY tidak boleh kurang dari 1");
                    return;
                }

                DataRow dtR = dt.NewRow();
                
                dtR[0] = nama;
                dtR[1] = qty;
                dtR[2] = kolam;
                dtR[3] = harga;
                dtR[4] = subtotal;
                dtR[5] = id;
                dtR[6] = idkolam;
                dt.Rows.Add(dtR);

                //selectedIkanIndex = -1;
                countTotal();
            }
            else
            {
                MessageBox.Show("Ikan dan kolam harus dipilih");
            }
        }

        private void cmbIkan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIkan.SelectedIndex > -1)
            {
                int key = ((KeyValuePair<int, string>)cmbIkan.SelectedItem).Key;
                string value = ((KeyValuePair<int, string>)cmbIkan.SelectedItem).Value;
                selectedIkanIndex = key;
            }
        }

        private void cmbKolam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKolam.SelectedIndex > -1)
            {
                int key = ((KeyValuePair<int, string>)cmbKolam.SelectedItem).Key;
                string value = ((KeyValuePair<int, string>)cmbKolam.SelectedItem).Value;
                selectedKolamIndex = key;
            }
        }

        public void countTotal()
        {
            total = 0;
            foreach (DataRow item in dt.Rows)
            {
                total += int.Parse(item[4].ToString());
            }
            labeltotal.Text = total.ToString();
        }

        private void Tambah_Load(object sender, EventArgs e)
        {
            this.Paint += new PaintEventHandler(Tambah_Paint);
        }

        private void Tambah_Paint(object sender, PaintEventArgs e)
        {
            // membuat gradient background
            LinearGradientBrush gradient = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(255, 25, 25, 112), // biru tua
                Color.FromArgb(255, 135, 206, 250), // biru muda cerah
                -120f);
            e.Graphics.FillRectangle(gradient, this.ClientRectangle);
        }

        private void btnTambah_MouseHover(object sender, EventArgs e)
        {
            btnTambah.BackColor = Color.LightGreen;
        }

        private void btnTambah_MouseLeave(object sender, EventArgs e)
        {
            btnTambah.BackColor = Color.GhostWhite;
        }

        private void btnSelesai_MouseHover(object sender, EventArgs e)
        {
            btnSelesai.BackColor = Color.LightGreen;
        }

        private void btnSelesai_MouseLeave(object sender, EventArgs e)
        {
            btnSelesai.BackColor = Color.GhostWhite;
        }
    }
}
