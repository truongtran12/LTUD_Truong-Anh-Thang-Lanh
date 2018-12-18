﻿/* Trần Nhựt Trường
  Ngày làm: 15/11/2018
  Ngày hoàn thành: 15/11/2018
 * Kiểm tra Đăng nhập: 100%
   kiểm tra tài khoản mật khẩu : 100%
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class frmLogin : Form
    {
        string name;
        string type;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Bạn có muốn thoát không? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ms == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Ham kiem tra Dang nhap
        private bool CheckLogin(string username, string password, string typeA)
        {
            DataProvider provider = new DataProvider();
            DataTable table = provider.loadAccount();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][0].ToString() == username && table.Rows[i][2].ToString() == password && table.Rows[i][3].ToString() == typeA)
                {
                    name = table.Rows[i][1].ToString();
                    type = table.Rows[i][3].ToString();
                    MessageBox.Show("Xin chào "+name+" :)", "Đăng nhập thành công",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        //Su kien click btnLogin
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string type = "CASHIER";
                if (rdbAdmin.Checked == true)
                {
                    type = "ADMIN";
                }
                if (CheckLogin(user, pass, type) == true)
                {
                    frmMain main = new frmMain(user, name, pass, type);
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi...",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch
            {
                //neu chua co co so du lieu
                MessageBox.Show("Cơ sở dữ liệu không tồn tại", "Lỗi...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
