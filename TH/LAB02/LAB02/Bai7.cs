using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB02
{
    public partial class frmBai7 : Form
    {
        public frmBai7()
        {
            InitializeComponent();
            LoadDrives();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void LoadDrives()
        {
            treeView.Nodes.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("..."); // dấu hiệu có thể mở rộng
                treeView.Nodes.Add(node);
            }
        }
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear(); // xóa node giả "..."
            string path = node.Tag.ToString();

            try
            {
                // Thêm thư mục con
                foreach (var dir in Directory.GetDirectories(path))
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(dir));
                    subNode.Tag = dir;
                    subNode.Nodes.Add("...");
                    node.Nodes.Add(subNode);
                }

                // Thêm file con
                foreach (var file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file;
                    node.Nodes.Add(fileNode);
                }
            }
            catch { } // bỏ qua lỗi truy cập
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            if (!File.Exists(path)) return;

            string ext = Path.GetExtension(path).ToLower();

            // Ẩn tất cả các vùng hiển thị trước
            rtbContent.Visible = false;
            picImage.Visible = false;
            // axAcroPDF1.Visible = false; // nếu có PDF viewer

            try
            {
                if (ext == ".txt" || ext == ".cs" || ext == ".html" || ext == ".log")
                {
                    rtbContent.Text = File.ReadAllText(path);
                    rtbContent.Visible = true;
                }
                else if (ext == ".jpg" || ext == ".png" || ext == ".bmp" || ext == ".gif")
                {
                    picImage.Image = Image.FromFile(path);
                    picImage.SizeMode = PictureBoxSizeMode.Zoom;
                    picImage.Visible = true;
                }
                else if (ext == ".pdf")
                {
                    System.Diagnostics.Process.Start(path); // mở bằng app mặc định
                }
                else
                {
                    rtbContent.Text = "Không thể hiển thị loại file này.";
                    rtbContent.Visible = true;
                }
            }
            catch (Exception ex)
            {
                rtbContent.Text = "Lỗi khi mở file: " + ex.Message;
                rtbContent.Visible = true;
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
