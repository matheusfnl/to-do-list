using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyTodoList
{
    public partial class MyToDoList : Form
    {
        public MyToDoList()
        {
            InitializeComponent();
        }
        private void MyToDoList_Load(object sender, EventArgs e)
        {
            pnAdd.BackColor = Color.FromArgb(255, 135, 200, 135);
            pnTop.BackColor = Color.FromArgb(255, 135, 200, 135);
        }
        private void fillControlData(object sender, EventArgs e)
        {
            try
            {
                if (validadeData())
                {
                    //criar um TodoItem
                    //preencher o TodoItem
                    //criar um TodoControl
                    //preencher o TodoControl com as informações do TodoItem
                    TodoItem item = fillTodoItem();
                    ToDoControl boxControl = new ToDoControl(item);

                    tlpControlToDo.Controls.Add(boxControl);
                    //Adicionar o TodoControl no Panel
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                txtBoxAddTitle.Focus();
                //limpando as caixas de texto
                txtBoxAddTitle.Text = string.Empty;
                txtBoxAddDesc.Text = string.Empty;
            }
        }

        private TodoItem fillTodoItem()
        {
            //criando um TodoItem
            TodoItem item = new TodoItem();
            //preenchendo as informações do TodoItem
            item.title = txtBoxAddTitle.Text;
            item.desc = txtBoxAddDesc.Text;

            return item;
        }
        private bool validadeData()
        {
            //caso não possua titulo, exibir a mensagem informando ao usuário
            if (txtBoxAddTitle.Text.Trim() == string.Empty)
            {
                throw new Exception("O campo título é obrigatório");
            }

            return true;
        }

        //codigo do botão
        private void txtBoxAddTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxAddDesc.Focus();
            }
        }

        private void txtBoxAddDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                fillControlData(sender, e);
                txtBoxAddTitle.Focus();
            }
        }
    }
}
