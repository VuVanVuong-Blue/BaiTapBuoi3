using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapvenhaBUOI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLast.Text) &&
                !string.IsNullOrWhiteSpace(txtFirst.Text) &&
                !string.IsNullOrWhiteSpace(txtPhone.Text))
            { 
                ListViewItem item = new ListViewItem(txtLast.Text);
                item.SubItems.Add(txtFirst.Text);
                item.SubItems.Add(txtPhone.Text);
                listView1.Items.Add(item);
                txtLast.Clear();
                txtFirst.Clear();
                txtPhone.Clear();
            MessageBox.Show("Thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                }
                MessageBox.Show("Xóa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (!string.IsNullOrWhiteSpace(txtLast.Text) &&
                    !string.IsNullOrWhiteSpace(txtFirst.Text) &&
                    !string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    selectedItem.Text = txtLast.Text;
                    selectedItem.SubItems[1].Text = txtFirst.Text;
                    selectedItem.SubItems[2].Text = txtPhone.Text;
                    txtLast.Clear();
                    txtFirst.Clear();
                    txtPhone.Clear();

                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        
            }
        }
}
