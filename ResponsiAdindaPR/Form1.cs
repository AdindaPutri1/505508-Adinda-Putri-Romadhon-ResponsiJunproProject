using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace ResponsiAdindaPR
{
    public partial class Form1 : Form
    {
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=admin123;Database=responsiDinda";
        NpgsqlConnection conn;
        string sql;
        NpgsqlCommand cmd;
        public DataTable dt;
        private DataGridViewRow row;

        public DataGridViewRow Row { get => row; set => row = value; }
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            conn = new NpgsqlConnection(connstring);
            try
            {
                sql = "Select * from karyawan departemen," +
               " WHERE karyawan.id_dep = departemen.id_dep;";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally {
                conn.Close();
            }
        }

        private void InsertData()
        {
            string nama = tbNama.Text;
            int id_dep = 0;

            if (cbDep.SelectedIndex == 1)
            {
                id_dep = cbDep.SelectedIndex;
            }
            else if (cbDep.SelectedIndex == 2)
            {
                id_dep = cbDep.SelectedIndex;
            }
            else if (cbDep.SelectedIndex == 3)
            {
                id_dep = cbDep.SelectedIndex;
            }
            else if (cbDep.SelectedIndex == 4) 
            {
                id_dep = cbDep.SelectedIndex;
            }
            else if (cbDep.SelectedIndex == 5)
            {
                id_dep = cbDep.SelectedIndex;
            }

            if (id_dep == 0)
            {
                MessageBox.Show("Pilih departemen!");
                return;
            }

            bool isDepExist = false;
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();
                sql = "SELECT COUNT(*) FROM departemen WHERE id_dep = @id_dep";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id_dep", id_dep);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    MessageBox.Show("Pilih Departemen");
                    return;
                }
                else
                {
                    isDepExist = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            finally
            {
                conn.Close();
            }
        }

        private void EditData()
        {
            if (Row == null)
            {
                MessageBox.Show("Pilih karyawan untuk diedit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string id_karyawan = Row.Cells["id_karyawan"].Value.ToString();
            string id_dep = Row.Cells["id_dep"].Value.ToString();
            string nama = Row.Cells["nama"].Value.ToString();

            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                sql = "UPDATE karyawan SET nama = @in_nama, id_dep = @in_id_dep WHERE id_karyawan = @in_id_karyawan";

                cmd.Parameters.AddWithValue("@in_nama", nama);
                cmd.Parameters.AddWithValue("@in_id_dep", id_dep);
                cmd.Parameters.AddWithValue("@in_id_karyawan", id_karyawan);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("[200] Edit Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                else
                {
                    MessageBox.Show("[404] Karyawan tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DeleteData()
        {
            if (row == null)
            {
                MessageBox.Show("Pilih karyawan yang ingin dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id_karyawan = Row.Cells["id_karyawan"].Value.ToString();
            MessageBox.Show("iD KARYAWAN YANG DIPILIH " + id_karyawan);

            DialogResult dialogresult = MessageBox.Show("Apakah Anda yakin untuk menghapus karyawan ini?", "konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult == DialogResult.No)
            {
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connstring);
                conn.Open();

                sql = "DELETE FROM karyawan WHERE id_karyawan = @in_id_karyawan";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@in_id_karyawan", id_karyawan);

                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("[200] Edit Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();

                }
                else
                {
                    MessageBox.Show("[404] Karyawan tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
            private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                Row = dataGridView1.Rows[e.RowIndex];
                tbNama.Text = Row.Cells["Nama"].Value.ToString();
                int id_dep = (int)Row.Cells["id_dep"].Value;

                if (id_dep == 1) {cbDep.SelectedIndex = 1; }
                else if (id_dep == 2) {cbDep.SelectedIndex = 2; }
                else if(id_dep == 3) {  cbDep.SelectedIndex = 3; }
                else if (id_dep == 4) {cbDep.SelectedIndex = 4; }
                else if (id_dep == 5) { cbDep.SelectedIndex = 5; }
            }
           

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertData();
        }
    }
}
