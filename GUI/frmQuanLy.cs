using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class frmQuanLy : Form
    {
        private List<TextBox> ltextbox = new List<TextBox>();
        private List<Label> llabel = new List<Label>();
        private Point _locationNextTextBox;
        private bool FirstLoadDataGridViews = false;

        // Kiểu bảng nào truyền vào
        private GUI.MyStruct.MyTableName _tablename = new MyStruct.MyTableName();
        


        public frmQuanLy(GUI.MyStruct.MyTableName nameTable)
        {
            InitializeComponent();
            this.MinimizeBox = this.MaximizeBox = false;
            this.MaximumSize = this.MinimumSize = new Size(1100, 550);
            this.dataGridView1.ReadOnly = true;

            _tablename = nameTable;
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            this.Text = @"Quản lý " + _tablename.ToString();
            EditMode(true);
            GUI.FillTo.DataGridViews(_tablename.ToString(), ref this.dataGridView1);
            FirstLoadDataGridViews = true;

            _locationNextTextBox = this.groupBox3.Location;

            Label lb;
            TextBox tb;

            for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                // tạo label mới hiển thị nhãn
                lb = new Label();
                lb.Text = this.dataGridView1.Columns[i].Name;
                lb.AutoSize = true;
                lb.Size = new System.Drawing.Size(35, 13);

                // tạo một textbox mới hiển thị giá trị
                tb = new TextBox();
                tb.Size = new System.Drawing.Size(160, 20);
                tb.Enabled = false;

                // chỉnh toạ độ
                _locationNextTextBox.Y += 25;
                lb.Location = new Point(_locationNextTextBox.X + 5, _locationNextTextBox.Y - 190);
                tb.Location = new Point(_locationNextTextBox.X + 90, _locationNextTextBox.Y - 190);

                // gán textbox và label vào trong groupbox
                this.groupBox3.Controls.Add(lb);
                this.groupBox3.Controls.Add(tb);

                // thêm vào danh sách
                llabel.Add(lb);
                ltextbox.Add(tb);
            }
        }

        /// <summary>
        /// 
        /// Chế độ chỉnh sửa thông tin
        /// 
        /// </summary>
        /// <param name="_bState_Hide"></param>
        private void EditMode(bool _bState_Hide = true)
        {
            button5_LuuThayDoi.Enabled = button7_HuyBo.Enabled = !_bState_Hide;
        }

        /// <summary>
        /// 
        /// Sửa trạng thái hoạt động cho tất cả textbox 
        /// 
        /// </summary>
        /// <param name="lt"></param>
        /// <param name="_EditMode"></param>
        private void StateAll_ListTextBox(ref List<TextBox> lt, bool _EditMode = true)
        {
            for (int i = 0; i < lt.Count; i++)
            {
                lt[i].Enabled = _EditMode;
            }
        }

        private void button4_ThayDoi_Click(object sender, EventArgs e)
        {
            EditMode(false);
            StateAll_ListTextBox(ref ltextbox, true);

            // Chỉnh những bảng nào ko được phép sửa (VD: Khoá chính)
            switch (_tablename)
            {
                case MyStruct.MyTableName.DUAN:
                case MyStruct.MyTableName.LUONG:
                case MyStruct.MyTableName.NHANVIEN:
                case MyStruct.MyTableName.PHONGBAN:
                case MyStruct.MyTableName.TAIKHOAN:
                    ltextbox[0].Enabled = false;
                    break;
                case MyStruct.MyTableName.PHANCONG:
                    ltextbox[0].Enabled = ltextbox[1].Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void button7_HuyBo_Click(object sender, EventArgs e)
        {
            EditMode(true);
            StateAll_ListTextBox(ref ltextbox, false);
        }

        private void button3_Them_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (FirstLoadDataGridViews)
            {
                for (int i = 0; i < this.dataGridView1.ColumnCount; i++)
                {
                    ltextbox[i].Text = this.dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                }
            }
        }

        private void button2_LamMoi_Click(object sender, EventArgs e)
        {
            GUI.FillTo.DataGridViews(_tablename.ToString(), ref this.dataGridView1);
        }
    }
}
