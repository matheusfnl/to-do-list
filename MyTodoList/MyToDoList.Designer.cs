
namespace MyTodoList
{
    partial class MyToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxAddTitle = new System.Windows.Forms.TextBox();
            this.txtBoxAddDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddControl = new System.Windows.Forms.Button();
            this.pnAdd = new System.Windows.Forms.Panel();
            this.pnBack = new System.Windows.Forms.Panel();
            this.tlpControlToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnAdd.SuspendLayout();
            this.pnBack.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ebrima", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "My To Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "TÍTULO";
            // 
            // txtBoxAddTitle
            // 
            this.txtBoxAddTitle.Location = new System.Drawing.Point(7, 26);
            this.txtBoxAddTitle.Name = "txtBoxAddTitle";
            this.txtBoxAddTitle.Size = new System.Drawing.Size(270, 23);
            this.txtBoxAddTitle.TabIndex = 3;
            this.txtBoxAddTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAddTitle_KeyDown);
            // 
            // txtBoxAddDesc
            // 
            this.txtBoxAddDesc.Location = new System.Drawing.Point(7, 75);
            this.txtBoxAddDesc.Name = "txtBoxAddDesc";
            this.txtBoxAddDesc.Size = new System.Drawing.Size(270, 23);
            this.txtBoxAddDesc.TabIndex = 4;
            this.txtBoxAddDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxAddDesc_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIÇÃO";
            // 
            // btnAddControl
            // 
            this.btnAddControl.Location = new System.Drawing.Point(7, 109);
            this.btnAddControl.Name = "btnAddControl";
            this.btnAddControl.Size = new System.Drawing.Size(75, 23);
            this.btnAddControl.TabIndex = 6;
            this.btnAddControl.Text = "Adicionar";
            this.btnAddControl.UseVisualStyleBackColor = true;
            this.btnAddControl.Click += new System.EventHandler(this.fillControlData);
            // 
            // pnAdd
            // 
            this.pnAdd.BackColor = System.Drawing.Color.White;
            this.pnAdd.Controls.Add(this.btnAddControl);
            this.pnAdd.Controls.Add(this.label2);
            this.pnAdd.Controls.Add(this.txtBoxAddDesc);
            this.pnAdd.Controls.Add(this.txtBoxAddTitle);
            this.pnAdd.Controls.Add(this.label3);
            this.pnAdd.ForeColor = System.Drawing.Color.Black;
            this.pnAdd.Location = new System.Drawing.Point(21, 93);
            this.pnAdd.Name = "pnAdd";
            this.pnAdd.Size = new System.Drawing.Size(285, 140);
            this.pnAdd.TabIndex = 0;
            // 
            // pnBack
            // 
            this.pnBack.BackColor = System.Drawing.Color.LightGreen;
            this.pnBack.Controls.Add(this.tlpControlToDo);
            this.pnBack.Controls.Add(this.pnTop);
            this.pnBack.Controls.Add(this.pnAdd);
            this.pnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBack.Location = new System.Drawing.Point(0, 0);
            this.pnBack.Name = "pnBack";
            this.pnBack.Size = new System.Drawing.Size(861, 541);
            this.pnBack.TabIndex = 2;
            // 
            // tlpControlToDo
            // 
            this.tlpControlToDo.AutoScroll = true;
            this.tlpControlToDo.AutoScrollMargin = new System.Drawing.Size(0, 1000);
            this.tlpControlToDo.AutoScrollMinSize = new System.Drawing.Size(0, 1000);
            this.tlpControlToDo.BackColor = System.Drawing.Color.Transparent;
            this.tlpControlToDo.Location = new System.Drawing.Point(385, 101);
            this.tlpControlToDo.Name = "tlpControlToDo";
            this.tlpControlToDo.Size = new System.Drawing.Size(436, 428);
            this.tlpControlToDo.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.White;
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.ForeColor = System.Drawing.Color.White;
            this.pnTop.Location = new System.Drawing.Point(373, 12);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(458, 77);
            this.pnTop.TabIndex = 1;
            // 
            // MyToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 541);
            this.Controls.Add(this.pnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My To Do List";
            this.Load += new System.EventHandler(this.MyToDoList_Load);
            this.pnAdd.ResumeLayout(false);
            this.pnAdd.PerformLayout();
            this.pnBack.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxAddTitle;
        private System.Windows.Forms.TextBox txtBoxAddDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddControl;
        private System.Windows.Forms.Panel pnAdd;
        private System.Windows.Forms.Panel pnBack;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.FlowLayoutPanel tlpControlToDo;
    }
}

