using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyTodoList
{
    public partial class ToDoControl : UserControl
    {
        private readonly TodoItem item;
        bool check = false;
        bool editing = false;
        public ToDoControl(TodoItem item)
        {
            InitializeComponent();
            this.item = item;

            //atualizando os dados
            lbTitle.Text = item.title;
            lbDesc.Text = item.desc;
            
        }

        private void removeControl(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void markChecked(object sender, MouseEventArgs e)
        {
            if(editing == false)
            {
                check = !check;
            }

            if (check && editing == false)
            {
                pnToDoControl.BackColor = Color.FromArgb(255, 135, 200, 135);
                lbDesc.BackColor = Color.FromArgb(255, 135, 200, 135);
                lbTitle.BackColor = Color.FromArgb(255, 135, 200, 135);
                lbDesc.ForeColor = System.Drawing.Color.White;
                lbTitle.ForeColor = System.Drawing.Color.White;
                this.BorderStyle = BorderStyle.None;

            }
            else if(!check && editing == false)
            {
                pnToDoControl.BackColor = Color.White;
                lbDesc.BackColor = Color.White;
                lbTitle.BackColor = Color.White;
                lbDesc.ForeColor = System.Drawing.Color.Black;
                lbTitle.ForeColor = System.Drawing.Color.Black;
                this.BorderStyle = BorderStyle.FixedSingle;

            }
        }
        private void editInfoControl(object sender, EventArgs e)
        {
            check = false;
            editing = !editing;
            if (editing)
            {
                lbTitle.Focus();
                btnEdit.Image = Imagens.confirmIcon;
                lbDesc.ReadOnly = false;
                lbTitle.ReadOnly = false;
                pnToDoControl.BackColor = Color.FromArgb(255, 210, 247, 236);
                lbDesc.BackColor = Color.FromArgb(255, 210, 247, 236);
                lbTitle.BackColor = Color.FromArgb(255, 210, 247, 236);
                lbDesc.ForeColor = System.Drawing.Color.Black;
                lbTitle.ForeColor = System.Drawing.Color.Black;
                this.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                btnEdit.Image = Imagens.editIcon;
                lbDesc.ReadOnly = true;
                lbTitle.ReadOnly = true;
                pnToDoControl.BackColor = Color.White;
                lbDesc.BackColor = Color.White;
                lbTitle.BackColor = Color.White;

            }
        }

        private void lbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbDesc.Focus();
            }
        }

    }
}
