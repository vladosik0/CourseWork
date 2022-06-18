using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShopNet;
namespace Kursach
{
    public partial class Form5 : Form
    {
        private Form1 _mainform;
        private class NoShopOpenedException : Exception
        {
            public NoShopOpenedException(string message) : base(message)
            {

            }
        }
        public Form5(Form1 mainform)
        {
            _mainform = mainform;
            InitializeComponent();
            UpdateProductsDT();
        }
        //Обробка події натискання кнопки "Додати в асортимент"
        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Shop.ListOfShops.Count() == 0)
                {
                    throw new NoShopOpenedException("Ви не можете додати товар, оскільки у вас не відкрито жодного магазину!!!");
                }
                if(Convert.ToDouble(priceTB.Text)<=0)
                {
                    throw new Exception();
                }
                Product product = new Product(Guid.NewGuid(),Convert.ToDouble(priceTB.Text), nameTB.Text);
            }
            catch(NoShopOpenedException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ProductException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Продукт додано до асортименту вашої мережі", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateProductsDT();
            _mainform.UpdateNumbersOfProductsDT();
        }
        //Оновлення productsDataGridView, де відображуюється асортимент товарів
        private void UpdateProductsDT()
        {
            DataTable productsDT = new DataTable();
            productsDT.Columns.Add("Найменування товару", typeof(string));
            productsDT.Columns.Add("Ціна, грн", typeof(double));
            foreach (var product in Shop.ListOfProducts)
            {
                productsDT.Rows.Add(product.Value.Name, product.Value.Price);
            }
            productsDV.DataSource = productsDT;
        }

    }
}
