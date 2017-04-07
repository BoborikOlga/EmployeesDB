using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Configuration;

namespace testTask
{

    public delegate void AddDelegate(string name, string surname, string position, int year, double salary);
    public delegate void LoadPositionsDelegate(ComboBox cbPositions);

    public partial class fMain : Form
    {
        public DBManager managerDB = new DBManager();
        public EmployeesTree tree = new EmployeesTree();
        public string tableName = "EmployeeData";
        public List<string> positionsList;

        public fMain()
        {
            InitializeComponent();
        }


        private void LoadDataToTree(DataTable dt)
        {
            DataTableReader dtReader = dt.CreateDataReader();

            while (dtReader.Read())
            {
                Employee newEmployee = new Employee(Convert.ToInt32(dtReader.GetValue(0)), dtReader.GetValue(1).ToString(), dtReader.GetValue(2).ToString(),
                    dtReader.GetValue(3).ToString(), Convert.ToInt32(dtReader.GetValue(4)), Convert.ToDouble(dtReader.GetValue(5)));
                tree.Add(newEmployee);
            }
            dtReader.Close();
        }

      
        private void DisplayTree(Node current)
        {
            if (current != null)
            {
                dgvEmployeeTable.Rows.Add(current.data.id, current.data.name, current.data.surname,
                    current.data.position,current.data.bornYear.ToString(), current.data.salary.ToString());
                DisplayTree(current.left);              
                DisplayTree(current.right);
            }
        }

        public void UpDateDataGrid(EmployeesTree tree = null)
        {
            while (dgvEmployeeTable.Rows.Count > 1)
                for (int i = 0; i < dgvEmployeeTable.Rows.Count - 1; i++)
                    dgvEmployeeTable.Rows.Remove(dgvEmployeeTable.Rows[i]);
            DisplayTree(tree.root);
            LoadPositionsFromDataBase(cbPositions);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            string cnStr = ConfigurationManager.AppSettings["cnStr"];
            managerDB.OpenConnection(cnStr);

            DataTable employeesDT = managerDB.GetAllRecordsAsDataTable(tableName);
            LoadDataToTree(employeesDT);
            DisplayTree(tree.root);
            dgvEmployeeTable.Sort(colID, ListSortDirection.Ascending);
            LoadPositionsFromDataBase(cbPositions);

        }

        private void LoadPositionsFromDataBase(ComboBox cbName)
        {
            for (int i = 0; i < cbName.Items.Count; i++)
                cbName.Items.Remove(cbName.Items[i]);

            List<string> positionsList = managerDB.GetPositions(tableName);

            for (int i = 0; i < positionsList.Count; i++)
                cbName.Items.Add(positionsList[i]);
        }

        private void bAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addForm = new AddEmployeeForm(new AddDelegate(AddEmployee), new LoadPositionsDelegate(LoadPositionsFromDataBase));
            addForm.ShowDialog();
        }

        private void AddEmployee(string name, string surname, string position, int year, double salary)
        {
            int lastID = managerDB.GetLastIndex(tableName);
            Employee newEmployee = new Employee(lastID + 1, name,surname, position, year, salary);
            managerDB.InsertRecord(tableName, newEmployee);
            tree.Add(newEmployee);
            UpDateDataGrid();
            LoadPositionsFromDataBase(cbPositions);
        }

        private void DeleteEmployee(int id)
        {
            managerDB.DeleteRecord(tableName, id);
            tree.Delete(id);
            UpDateDataGrid();
            LoadPositionsFromDataBase(cbPositions);
        }

        private void bDeleteEmloyee_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeTable.CurrentRow != null)
                DeleteEmployee((int)dgvEmployeeTable[0, dgvEmployeeTable.CurrentRow.Index].Value);
            else
                MessageBox.Show("Выберите сотрудника!");
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            EmployeesTree onePositionTree = new EmployeesTree();
            string position = cbPositions.Text.Substring(0, 1).ToUpper() + cbPositions.Text.Remove(0, 1);

            tree.Find(position, onePositionTree);
            if (onePositionTree.root != null)
            {
                DisplayTree(onePositionTree.root);
                UpDateDataGrid(onePositionTree);
            }
            else
                MessageBox.Show("Информация о сотрудниках данной должности не найдена!");
            onePositionTree = null;
        }

        private void bShowAllPositions_Click(object sender, EventArgs e)
        {
            UpDateDataGrid(tree);
            dgvEmployeeTable.Sort(colID, ListSortDirection.Ascending);
            cbPositions.Text = "";
        }


        private void cbPositions_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l != '\b') && (l != '-'))
                e.Handled = true;
        }
    }
}
