using System;
using System.Windows.Forms;
using ShopNet;
namespace Kursach
{
    public partial class HireSalesmanForm : Form
    {
        private Form1 _mainForm;
        private class ListOverFlowException : Exception
        {
            public ListOverFlowException(string message) : base(message)
            {

            }
        }
        public HireSalesmanForm(Form1 mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }   
        //Обробка події натискання кнопки "Найняти"
        private void addSalesmanButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                Shop currentShop=_mainForm.GetShop();
                string firstName = firstNameTB.Text;
                string middleName = middleNameTB.Text;
                string lastName = lastNameTB.Text;
                decimal salary = Convert.ToDecimal(salaryTB.Text);
                foreach (var shop in Shop.ListOfShops)
                {
                        if(currentShop.ListOfSalesmen.Count+1>currentShop.MaxSalesmenNumber)
                    {
                        throw new ListOverFlowException($"У вашому магазині не може бути кількість продавців, більша за {currentShop.MaxSalesmenNumber}!!!") ;
                    }
                    Salesman salesman = new Salesman(Guid.NewGuid(), firstName, middleName, lastName, salary,currentShop);
                        _mainForm.UpdateSalesmanDT(currentShop);
                        break;
                }
            }
            catch(ListOverFlowException ex)
            {
                MessageBox.Show(ex.Message,"Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("У магазині з'явився новий продавець", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
