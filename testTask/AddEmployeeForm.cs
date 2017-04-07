using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTask
{
    public partial class AddEmployeeForm : Form
    {

        fMain mainForm;
        AddDelegate addEmployeeDelegate;
        LoadPositionsDelegate loadPositionsListDelegate;

        public AddEmployeeForm(AddDelegate addSender, LoadPositionsDelegate loadSender)
        {
            InitializeComponent();
            loadPositionsListDelegate = loadSender;
            loadPositionsListDelegate(cbPosition);
            addEmployeeDelegate = addSender;
        }

        public AddEmployeeForm()
        {
            mainForm = this.Owner as fMain;     
            InitializeComponent();            
        }

        private bool CheckEmptyFields()
        {
            if ((tbName.Text == "") || (tbSurname.Text == "") || (cbPosition.Text == "")
                || (tbYear.Text == "") || (tbSalary.Text == ""))
                return false;
            else
                return true;
        }


        private string StringToUpper(string originalString)
        {
            originalString = originalString.Substring(0, 1).ToUpper() + originalString.Remove(0, 1);
            return originalString;
        }

        private void bAddEmployee_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                addEmployeeDelegate(StringToUpper(tbName.Text), StringToUpper(tbSurname.Text), StringToUpper(cbPosition.Text),
                    Convert.ToInt32(tbYear.Text), Convert.ToDouble(tbSalary.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }



        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar)) | (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }


        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == 8)) return;
            else
                e.Handled = true;
        }

        private void CheckLetters(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l != '\b') && (l != '-') && (l != ' '))
                e.Handled = true;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(sender, e);
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(sender, e);
        }

        private void cbPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckLetters(sender, e);
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbYear.Text.Length == 4)
            {
                int year = Convert.ToInt32(tbYear.Text);
                DateTime currentYear = DateTime.Now;

                if ((year < 1930) || (year > (currentYear.Year - 18)))
                {
                    MessageBox.Show("Некорректный год рождения!");
                    tbYear.Clear();
                }
            }
        }

    }
}
