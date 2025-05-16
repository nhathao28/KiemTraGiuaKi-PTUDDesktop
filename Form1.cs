using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<NhanVien> danhSach = new List<NhanVien>();
       
        public class NhanVien
        {
            public string MaSo { get; set; }
            public string HoTen { get; set; }
            public string NgaySinh { get; set; }
            public string Email { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            bool dangThem = false;
        }
        void loadDulieu()
        {
            string path = Path.Combine(Application.StartupPath, "dulieu.txt");
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        danhSach.Add(new NhanVien
                        {
                            MaSo = parts[0],
                            HoTen = parts[1],
                            NgaySinh = parts[2],
                            Email = parts[3]
                        });
                    }
                }
            }
            HienThiLenListView();
        }
        void HienThiLenListView()
        {
            listView1.Items.Clear();
            foreach (var nv in danhSach)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(nv.HoTen);
                item.SubItems.Add(nv.NgaySinh);
                item.SubItems.Add(nv.Email);
                listView1.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadDulieu();
            btnLuu.Enabled= false;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                txtMaSo.Text = item.SubItems[0].Text;
                txtHoTen.Text= item.SubItems[1].Text;
                txtNgaySinh.Text= item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }
        bool dangThem = false;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!dangThem)
            {
                txtMaSo.Clear();
                txtHoTen.Clear();
                txtNgaySinh.Clear();
                txtEmail.Clear();
               
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                dangThem = true;
            }
            else
            {
                btnThem.Text = "Thêm";
                btnLuu.Enabled = false;
                dangThem = false;
            }
        }
        private void btnLuu_click (object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaSo = txtMaSo.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = txtNgaySinh.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };
            danhSach.Add(nv);
            HienThiLenListView();
            LuuDuLieuXuongFile();

            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            dangThem=false;
        }
        void LuuDuLieuXuongFile()
        {
            string path = Path.Combine(Application.StartupPath, "dulieu.txt");
            List<string> list = new List<string>(); 
            foreach (var nv in danhSach)
            {
                list.Add($"{nv.MaSo}; {nv.HoTen};{nv.NgaySinh};{nv.Email}");
            }
            File.WriteAllLines(path, list);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
