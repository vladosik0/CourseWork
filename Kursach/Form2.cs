using System;
using System.Linq;
using System.Windows.Forms;
using ShopNet;
namespace Kursach
{
    public partial class Form2 : Form
    {
        private Form1 _mainForm;
        private class ShopException : Exception
        {
            public ShopException(string message) : base(message)
            {

            }
        }
        public Form2(Form1 mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
        //Обробник події натискання кнопки "Додати"
        private void addShopSubButton_Click(object sender, EventArgs e)
        {
            try
            {
                string address = getAddress.Text;
                double square = Convert.ToDouble(getSquare.Text);
                int maxSalesmenNumber = Convert.ToInt32(salesmenNumberTB.Text);
                if (Shop.ListOfShops.Contains(new Shop(Guid.NewGuid(), address, square, maxSalesmenNumber)))
                {
                    throw new ShopException("У вас не може бути більше 1 магазину за однаковою адресою!!!");
                }
                Base<Shop>.Items.Remove(Base<Shop>.Items.Last().Key);
                if (square <=0||maxSalesmenNumber<=0)
                {
                    throw new Exception();
                }
                if((double)square/maxSalesmenNumber<25)
                {
                    throw new Exception();
                }
                Shop.OpenNewShop(address, square,maxSalesmenNumber);
            }
            catch (ShopException ex)
            {
                MessageBox.Show(ex.Message,"Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Base<Shop>.Items.Remove(Base<Shop>.Items.Last().Key);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Магазин відкрито","Успіх",MessageBoxButtons.OK,MessageBoxIcon.Information);
            _mainForm.shopsCB.Items.Add(Shop.ListOfShops.Last());
            _mainForm.clientShopCB.Items.Add(Shop.ListOfShops.Last().Address);
            Close();
        }
    }
}
