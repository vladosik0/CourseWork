using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShopNet;

namespace Kursach
{
    public partial class Form6 : Form
    {
        Form1 _mainForm;
        Shop currentShop;
        Salesman salesman;
        double sumOfBuying = 0;
        private class NotEnoughMoneyException : Exception
        {
            public NotEnoughMoneyException(string message) : base(message)
            {

            }
        }
//     Метод для отримання об'єкту класа "продавець", який був обраний в елементі ComboBox
     
        private Salesman GetSalesman(Shop shop)
        {
            return shop.ListOfSalesmen.Where(s => s.ToString().Equals(salesmenCB.SelectedItem.ToString())).Single();

        }
        //     Метод для отримання об'єкту класа "магазин", який був обраний в елементі ComboBox
        private Shop GetShop()
        {
            return Shop.ListOfShops.Where(s => s.Address.Equals(_mainForm.clientShopCB.SelectedItem.ToString())).Single();
        }
        //     Метод для оновлення вмісту кошика в BasketDataGridView

        private void UpdateBasketDT()
        {
            DataTable basketDT = new DataTable();
            basketDT.Columns.Add("ID", typeof(Guid));
            basketDT.Columns.Add("Найменування товару", typeof(string));
            basketDT.Columns.Add("Ціна,грн", typeof(double));
            foreach (var product in _mainForm.listOfProducts)
            {
                basketDT.Rows.Add(product.ID, product.Name, product.Price);
            }
            basketDV.DataSource = basketDT;
        }
        public Form6(Form1 mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            basketDV.DataSource = _mainForm.basketDV.DataSource;
            basketDV.Columns[0].Visible = false;
            shopAddress.Text = _mainForm.clientShopCB.SelectedItem.ToString();
            currentShop = GetShop();
            foreach (var salesman in currentShop.ListOfSalesmen)
            {
                salesmenCB.Items.Add(salesman.ToString());
            }
            foreach(var product in _mainForm.listOfProducts)
            {
                sumOfBuying += product.Price;
            }
            priceTB.Text = _mainForm.priceOfBuyingTB.Text;
            ControlBox = false;
        }
        //Обробник події натискання на кнопку "Оформити покупку"
        private void verifyBuying_Click(object sender, EventArgs e)
        {
            salesman = GetSalesman(currentShop);
            try 
            {
                if (Convert.ToDouble(balanceTB.Text) < Convert.ToDouble(priceTB.Text))
                {
                    throw new NotEnoughMoneyException("На вашому балансі недостатньо коштів, щоб заплатити за покупку!!!");
                }
                Buying newBuying = new Buying(Guid.NewGuid(), _mainForm.listOfProducts);
                Client currentClient = new Client(Guid.NewGuid(),firstNameTB.Text, middleNameTB.Text, lastNameTB.Text, Convert.ToDouble(balanceTB.Text),newBuying,salesman);
                newBuying.Client= currentClient;
                salesman.ListOfClients.Add(currentClient);
                if(Convert.ToInt32(rateTB.Text)<1|| Convert.ToInt32(rateTB.Text)>5)
                {
                    throw new Exception();
                }
                salesman.Rates.Add(Convert.ToInt32(rateTB.Text));
               
            }
            catch (NotEnoughMoneyException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch(Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Дякуємо за покупку!","Дякуємо!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
        }
        //ЗМіна вмісту servingTextBox при зміні продавця, який відображається в ComboBox
        private void salesmenCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            salesman = GetSalesman(currentShop);
            servingTB.Text = salesman.ServeClient();
        }
        //Обробник події натискання на кнопку "Видалити товар з кошика"
        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви точно хочете прибрати покупку з кошика?", "Кошик", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Product product = _mainForm.listOfProducts.Where(p => p.ID.Equals(basketDV.SelectedRows[0].Cells[0].Value)).Single();
                    product.isBuyed = false;
                    sumOfBuying -= product.Price;
                    priceTB.Text = sumOfBuying.ToString();
                    _mainForm.listOfProducts.Remove(product);
                    _mainForm.UpdateNumbersOfProductsDT();
                    UpdateBasketDT();
                    MessageBox.Show("Товар прибрано з кошика", "Кошик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (basketDV.Rows.Count == 0)
                    {
                        MessageBox.Show("Ваш кошик порожній, поверніться до магазину та поповніть його", "Кошик", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Будь ласка, виділіть повністю всі поля покупки(натисніть стрілку у першій колонці напроти покупки)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                return;
            }
        }
        //Закриття форми
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
                while (_mainForm.basketDV.Rows.Count != 0)
                {
                    _mainForm.basketDV.Rows.Remove(_mainForm.basketDV.Rows[0]);
                }
                _mainForm.priceOfBuyingTB.Text = "0";
                _mainForm.UpdateSalesmanDT(GetShop());
            _mainForm.shopsCB.SelectedItem = _mainForm.GetShop().ToString();
            _mainForm.listOfProducts.Clear();
                _mainForm.Enabled = true;
            
        }
    }
}
