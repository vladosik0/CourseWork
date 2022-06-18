using System;
using System.Windows.Forms;
using ShopNet;
namespace Kursach
{
    public partial class Form4 : Form
    {
        private Form1 _mainForm;
        public Form4(Form1 mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
        //Метод для відображення рекомендованої зарплати продавця у полі recSalarytextBox
        public void setTB()
        {
            lastNameTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[1].Value.ToString();
            firstNameTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[2].Value.ToString();
            middleNameTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[3].Value.ToString();
            rateTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[4].Value.ToString();
            currentSalaryTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[4].Value.ToString();
            rateTB.Text = _mainForm.salesmenDV.SelectedRows[0].Cells[5].Value.ToString();
            double rate = Convert.ToDouble(rateTB.Text);

            if(rate==0)
            {
                recSalaryTB.Text = "Продавець ще не осблуговував клієнтів";
            }
            if (rate >= 1 && rate < 2)
            {
                recSalaryTB.Text = "Рекомендовано звільнити";
            }
            else if (rate >= 2 && rate < 3)
            {
                recSalaryTB.Text = "5000";
            }
            else if (rate >= 3 && rate < 4)
            {
                recSalaryTB.Text = "6000";

            }
            else if (rate >= 4 && rate < 5)
            {
                recSalaryTB.Text = "8000";
            }
            else if (rate == 5)
            {
                recSalaryTB.Text = "10000";
            }
            
        }
        //Обробка події натискання кнопки "Призначити зарплату"
        private void setSalaryButton_Click(object sender, EventArgs e)
        {
            Shop currentShop = _mainForm.GetShop();
            try
            {
                if(Convert.ToDecimal(recSalaryTB.Text)<0)
                {
                    throw new Exception();
                }
                currentShop.ChangeSalary(_mainForm.salesmenDV.CurrentCell.RowIndex, Convert.ToDecimal(recSalaryTB.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Зарплату змінено", "Зміна", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _mainForm.UpdateSalesmanDT(currentShop);
            Close();
        }


        



    }
}
