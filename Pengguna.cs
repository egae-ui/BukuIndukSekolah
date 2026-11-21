using System;
using System.Data;
using System.Windows.Forms;

namespace BukuIndukSekolah
{
    public partial class Pengguna : Form
    {
        public Pengguna()
        {
            InitializeComponent();
            tampildata();
            BtnTambah.Select();
        }

        private string Idu_pilih = null;

        // ─────────────────────────────────────────────────────────────
        public void tampildata()
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud("SELECT Idu, Username, Role FROM user ORDER BY Idu");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Idu  = "" + brs["Idu"];
                string User = "" + brs["Username"];
                string Role = "" + brs["Role"];
                // Kolom: 0=No, 1=Username, 2=Role, 3=Idu(hidden), 4=Edit, 5=Delete
                guna2DataGridView1.Rows.Add(no, User, Role, Idu);
                no++;
            }
        }

        private void bersih()
        {
            TxtUser.Text = "";
            TxtPass.Text = "";
            // Unsubscribe agar clear tidak trigger query
            CmbRole.DataSource = null;
            Idu_pilih = null;
        }

        // ─────────────────────────────────────────────────────────────
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bersih();
            PnlCrud.Visible = true;
            TxtUser.Select();
        }

        // ─────────────────────────────────────────────────────────────
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            DBBIS.crud(
                $"SELECT Idu, Username, Role FROM user " +
                $"WHERE Username LIKE '%{TxtSearch.Text}%' ORDER BY Idu");
            int no = 1;
            foreach (DataRow brs in DBBIS.ds.Tables[0].Rows)
            {
                string Idu  = "" + brs["Idu"];
                string User = "" + brs["Username"];
                string Role = "" + brs["Role"];
                guna2DataGridView1.Rows.Add(no, User, Role, Idu);
                no++;
            }
        }

        // ─────────────────────────────────────────────────────────────
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            string User = TxtUser.Text.Trim();
            string Pass = TxtPass.Text.Trim();
            string Role = CmbRole.Text.Trim();

            if (User == "" || Role == "")
            {
                MessageBox.Show("Username dan Role wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Idu_pilih == null && Pass == "")
            {
                MessageBox.Show("Password wajib diisi untuk pengguna baru!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Idu_pilih == null)
            {
                // INSERT — sertakan no_induk (kosong)
                DBBIS.crud(
                    $"INSERT INTO user (Username, Password, Role, no_induk) " +
                    $"VALUES ('{User}', MD5('{Pass}'), '{Role}', '')");
                MessageBox.Show("Pengguna berhasil ditambahkan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Pass == "")
                {
                    // UPDATE tanpa ubah password
                    DBBIS.crud(
                        $"UPDATE user SET Username='{User}', Role='{Role}' " +
                        $"WHERE Idu='{Idu_pilih}'");
                }
                else
                {
                    // UPDATE dengan ganti password
                    DBBIS.crud(
                        $"UPDATE user SET Username='{User}', Password=MD5('{Pass}'), Role='{Role}' " +
                        $"WHERE Idu='{Idu_pilih}'");
                }
                MessageBox.Show("Data pengguna berhasil diubah!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bersih();
            PnlCrud.Visible = false;
            tampildata();
        }

        // ─────────────────────────────────────────────────────────────
        private void CmbRole_DropDown(object sender, EventArgs e)
        {
            DBBIS.crud("SELECT Role FROM role ORDER BY Role");
            if (DBBIS.ds.Tables[0].Rows.Count > 0)
            {
                CmbRole.DataSource    = DBBIS.ds.Tables[0];
                CmbRole.DisplayMember = "Role";
            }
        }

        // ─────────────────────────────────────────────────────────────
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row    = e.RowIndex;
            int column = e.ColumnIndex;
            if (row < 0) return;

            string idu = guna2DataGridView1.Rows[row].Cells[3].Value?.ToString();

            if (column == 4) // Edit
            {
                Idu_pilih = idu;

                // Ambil data user dari DB
                DBBIS.crud($"SELECT Username, Role FROM user WHERE Idu='{idu}'");
                if (DBBIS.ds.Tables[0].Rows.Count > 0)
                {
                    DataRow brs   = DBBIS.ds.Tables[0].Rows[0];
                    string uname  = "" + brs["Username"];
                    string urole  = "" + brs["Role"];

                    TxtUser.Text = uname;
                    TxtPass.Text = ""; // Password tidak ditampilkan

                    // Isi dropdown role
                    DBBIS.crud("SELECT Role FROM role ORDER BY Role");
                    if (DBBIS.ds.Tables[0].Rows.Count > 0)
                    {
                        CmbRole.DataSource    = DBBIS.ds.Tables[0];
                        CmbRole.DisplayMember = "Role";
                    }
                    CmbRole.Text = urole;
                }
                PnlCrud.Visible = true;
                TxtUser.Select();
            }
            else if (column == 5) // Delete
            {
                string namaUser = guna2DataGridView1.Rows[row].Cells[1].Value?.ToString();
                DialogResult setuju = MessageBox.Show(
                    $"Hapus pengguna '{namaUser}'?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (setuju == DialogResult.Yes)
                {
                    DBBIS.crud($"DELETE FROM user WHERE Idu='{idu}'");
                    tampildata();
                }
            }
        }

        // ─────────────────────────────────────────────────────────────
        private void BtnBatal_Click_1(object sender, EventArgs e)
        {
            PnlCrud.Visible = false;
            bersih();
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && TxtUser.Text != "")
                TxtPass.Select();
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && TxtPass.Text != "")
                CmbRole.Select();
        }

        private void CmbRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && CmbRole.Text != "")
                BtnSimpan.Select();
        }
    }
}
