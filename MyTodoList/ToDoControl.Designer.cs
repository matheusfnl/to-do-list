
namespace MyTodoList
{
    partial class ToDoControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnToDoControl = new System.Windows.Forms.Panel();
            this.lbDesc = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.TextBox();
            this.pnToDoControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::MyTodoList.Imagens.deleteIcon;
            this.btnDelete.Location = new System.Drawing.Point(383, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(24, 24);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.removeControl);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::MyTodoList.Imagens.editIcon;
            this.btnEdit.Location = new System.Drawing.Point(383, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.editInfoControl);
            // 
            // pnToDoControl
            // 
            this.pnToDoControl.BackColor = System.Drawing.Color.White;
            this.pnToDoControl.Controls.Add(this.lbDesc);
            this.pnToDoControl.Controls.Add(this.lbTitle);
            this.pnToDoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnToDoControl.Location = new System.Drawing.Point(0, 0);
            this.pnToDoControl.Name = "pnToDoControl";
            this.pnToDoControl.Size = new System.Drawing.Size(412, 71);
            this.pnToDoControl.TabIndex = 4;
            this.pnToDoControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.markChecked);
            // 
            // lbDesc
            // 
            this.lbDesc.BackColor = System.Drawing.Color.White;
            this.lbDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDesc.Location = new System.Drawing.Point(11, 19);
            this.lbDesc.Multiline = true;
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.ReadOnly = true;
            this.lbDesc.Size = new System.Drawing.Size(364, 45);
            this.lbDesc.TabIndex = 1;
            this.lbDesc.Text = "example";
            this.lbDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.markChecked);

            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.White;
            this.lbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTitle.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(5, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.ReadOnly = true;
            this.lbTitle.Size = new System.Drawing.Size(373, 17);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "example";
            this.lbTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.markChecked);
            this.lbTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbTitle_KeyDown);
            // 
            // ToDoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnToDoControl);
            this.Name = "ToDoControl";
            this.Size = new System.Drawing.Size(412, 71);
            this.pnToDoControl.ResumeLayout(false);
            this.pnToDoControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnToDoControl;
        private System.Windows.Forms.TextBox lbDesc;
        private System.Windows.Forms.TextBox lbTitle;
    }
}
