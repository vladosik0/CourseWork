using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShopNet;
using Newtonsoft.Json;
using System.IO;
namespace Kursach
{
    public partial class Form1 : Form
    {
        DataTable basketDT = new DataTable();
        public List<Product> listOfProducts = new List<Product>();
        public class NoSalesmanException:Exception
        {
            public NoSalesmanException(string message):base(message)
            {

            }
        }
        public class EmptyBasketException : Exception
        {
            public EmptyBasketException(string message):base(message)
            {

            }
        }
        //Збереження списку магазинів у файл JSON
        public static void SaveShopItemsInFile()
        {
            string fileName = "D:/VisualStudio Projects/Kursach/DataBase/shopitems.json";
            string jsonString = JsonConvert.SerializeObject(Base<Shop>.Items);
            File.WriteAllText(fileName,jsonString);
        }
        //Збереження списку товарів у асортименті у файл JSON

        public static void SaveProductItemsInFile()
        {
            string fileName = "D:/VisualStudio Projects/Kursach/DataBase/productitems.json";
            string jsonString = JsonConvert.SerializeObject(Shop.ListOfProducts);
            File.WriteAllText(fileName, jsonString);
        }
        //Зчитування списку магазинів з файла JSON

        public static bool ReadShopItemsFromFile()
        {
            string fileName = "D:/VisualStudio Projects/Kursach/DataBase/shopitems.json";
            if (!File.Exists(fileName))
            {
                var result = MessageBox.Show("Хочете почати роботу без доданих магазинів, клієнтів і тд?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Перевірте папку D:/VisualStudio Projects/Kursach/DataBase на наявність файлу shopitems.json", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string jsonString = File.ReadAllText(fileName);
            Base<Shop>.Items = JsonConvert.DeserializeObject<Dictionary<Guid,Shop>>(jsonString);
            return true;
        }
        //Зчитування списку товарів у асортименті з файла JSON

        public static bool ReadProductItemsFromFile()
        {
            string fileName = "D:/VisualStudio Projects/Kursach/DataBase/productitems.json";
            if (!File.Exists(fileName))
            {
                var result = MessageBox.Show("Хочете почати роботу без доданих магазинів, клієнтів і тд?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Перевірте папку D:/VisualStudio Projects/Kursach/DataBase на наявність файлу productitems.json", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string jsonString = File.ReadAllText(fileName);
            Base<Product>.Items = JsonConvert.DeserializeObject<Dictionary<Guid, Product>>(jsonString);
            return true;
        }
        //Метод для отримання магазину, що обраний у елементі Combobox
        public Shop GetShop()
        {
            return Shop.ListOfShops.Where(s => s.ToString().Equals(shopsCB.SelectedItem.ToString())).Single();
        }
        //Оновлення SalesmanDataGridView, де відображається список продавців у магазині
        public void UpdateSalesmanDT(Shop currentShop)
        {
            if (currentShop.ListOfSalesmen == null)
            {
                return;
            }
            DataTable salesmenDT = new DataTable();
            salesmenDT.Columns.Add("ID", typeof(Guid));
            salesmenDT.Columns.Add("Прізвище", typeof(string));
            salesmenDT.Columns.Add("Ім'я", typeof(string));
            salesmenDT.Columns.Add("По батькові", typeof(string));
            salesmenDT.Columns.Add("Зарплата, грн", typeof(int));
            salesmenDT.Columns.Add("Рейтинг", typeof(double));
            
            foreach (var salesman in currentShop.ListOfSalesmen)
            {
                salesmenDT.Rows.Add(salesman.ID, salesman.LastName, salesman.FirstName, salesman.MiddleName, salesman.Salary, salesman.Rate);
            }
            salesmenDV.DataSource = salesmenDT;
            salesmenDV.Columns[0].Visible = false;
        }
        //Оновлення ClientsDataGridView, де відображається список клієнтів в обраного продавця
        public void UpdateClientsDT(Salesman salesman)
        {
            DataTable clientsDT = new DataTable();
            clientsDT.Columns.Add("ID", typeof(Guid));
            clientsDT.Columns.Add("Прізвище", typeof(string));
            clientsDT.Columns.Add("Ім'я", typeof(string));
            clientsDT.Columns.Add("По батькові", typeof(string));
            clientsDT.Columns.Add("Ціна покупки, грн", typeof(double));
            clientsDT.Columns.Add("Оцінка обслуговування", typeof(int));
            int i = 0;
            foreach (var client in salesman.ListOfClients)
            {
                clientsDT.Rows.Add(client.ID, client.LastName, client.FirstName, client.MiddleName, Math.Round(client.Buying.PriceOfBuying,2), salesman.Rates[i]);
                i++;
            }
            clientsDV.DataSource = clientsDT;
            clientsDV.Columns[0].Visible = false;
        }
        //Оновлення NumbersOfProductsDataGridView, де відображається асортимент товарів, доступний для клієнта
        public void UpdateNumbersOfProductsDT()
        {
            DataTable numberOfProductsDT = new DataTable();
            numberOfProductsDT.Columns.Add("ID", typeof(Guid));
            numberOfProductsDT.Columns.Add("Найменування товару", typeof(string));
            numberOfProductsDT.Columns.Add("Ціна, грн", typeof(double));
            foreach (var product in Shop.ListOfProducts)
            {
                numberOfProductsDT.Rows.Add(product.Key, product.Value.Name, product.Value.Price);
            }
            numberOfProductsDV.DataSource = numberOfProductsDT;
            numberOfProductsDV.Columns[0].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
           if(ReadShopItemsFromFile()&&ReadProductItemsFromFile())
            {
                foreach (var shop in Shop.ListOfShops)
                {
                    shopsCB.Items.Add(shop.ToString());
                    clientShopCB.Items.Add(shop.Address);
                }
                UpdateNumbersOfProductsDT();
            }
            basketDT.Columns.Add("ID", typeof(Guid));
            basketDT.Columns.Add("Найменування товару",typeof(string));
            basketDT.Columns.Add("Ціна,грн", typeof(double));
            priceOfBuyingTB.Text = "0";
        }
        //Обробка натиснення на кнопку "Відкрити новий магазин"
        private void openShopButton_Click(object sender, EventArgs e)
        {
            Form2 addNewShop = new Form2(this);
            addNewShop.Show();
        }
        //Обробка натиснення на кнопку "Найняти продавця"
        private void hireButton_Click(object sender, EventArgs e)
        {
            if(shopsCB.SelectedItem==null)
            {
                MessageBox.Show("Оберіть магазин, куди хочете найняти продавця", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form3 addNewSalesman = new Form3(this);
            addNewSalesman.Show();
        }
        //Обробка зміни поточного магазину в Combobox
        private void shopsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shop currentShop = GetShop();
            UpdateSalesmanDT(currentShop);
            while(clientsDV.Rows.Count!=0)
            {
                clientsDV.Rows.Remove(clientsDV.Rows[0]);
            }
        }
        //Обробка натиснення на кнопку "Звільнити продавця"

        private void firingButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви точно хочете звільнити продавця?", "Звільнення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Shop currentShop = GetShop();
                    Salesman salesman = currentShop.ListOfSalesmen.Where(s => s.ID.Equals(salesmenDV.SelectedRows[0].Cells[0].Value)).Single();
                    currentShop.FireSalesman(salesman);
                    UpdateSalesmanDT(currentShop);
                    while (clientsDV.Rows.Count != 0)
                    {
                        clientsDV.Rows.Remove(clientsDV.Rows[0]);
                    }
                    MessageBox.Show("Продавця звільнено", "Звільнення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Будь ласка, виділіть повністю всі поля продавця(натисніть стрілку у першій колонці напроти продавця)","Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("Будь ласка, оберіть магазин, де працює продавець", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                return;
            }
        }
        //Обробка натиснення на кнопку "Змінити зарплатню"
        private void changeSalary_Click(object sender, EventArgs e)
        {
            Form4 setSalaryForm = new Form4(this);
            try 
            {
                setSalaryForm.Show();
                setSalaryForm.setTB();
            }
            catch(ArgumentOutOfRangeException)
            {
                setSalaryForm.Close();
                MessageBox.Show("Будь ласка, виділіть повністю всі поля продавця(натисніть стрілку у першій колонці напроти продавця)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
        //Обробка натиснення на кнопку "Переглянути список товарів"

        private void showProductList_Click(object sender, EventArgs e)
        {
            Form5 showProducts = new Form5(this);
            showProducts.Show();
        }
        //Обробка подвійного натиснення на товар з асортименту для додавання його в кошик
        private void numberOfProductsDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid ID = Guid.Parse(numberOfProductsDV.Rows[numberOfProductsDV.CurrentCell.RowIndex].Cells[0].Value.ToString());
            basketDT.Rows.Add(Shop.ListOfProducts[ID].ID, Shop.ListOfProducts[ID].Name,Shop.ListOfProducts[ID].Price);
            listOfProducts.Add(Shop.ListOfProducts[ID]);
            Shop.ListOfProducts[ID].isBuyed = true;
            UpdateNumbersOfProductsDT();
            if(Shop.ListOfProducts.Count==0)
            {
                MessageBox.Show("Полиці магазину пусті", "Магазин", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            basketDV.DataSource = basketDT;
            basketDV.Columns[0].Visible = false;
            double result = Convert.ToDouble(priceOfBuyingTB.Text)+listOfProducts.Last().Price;
            priceOfBuyingTB.Text = result.ToString();
        }
        //Обробка натиснення на кнопку "Оформити покупку"
        private void buyingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listOfProducts.Count == 0)
                {
                    throw new EmptyBasketException("Ваш кошик порожній! Будь ласка, наповніть його або дочекайтеся завозу нових товарів");
                }
                Form6 buyingForm = new Form6(this);
                if ((Shop.ListOfShops.Where(s => s.Address.Equals(clientShopCB.SelectedItem.ToString())).Single().ListOfSalesmen.Count)==0)
                {
                    throw new NoSalesmanException("В цьому магазині немає продавців, оберіть інший!");
                }
                buyingForm.Show();
                Enabled = false;
            }
            catch(NoSalesmanException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(EmptyBasketException ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("Оберіть магазин, в якому ви оформлюєте покупку!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Обробка подвійного натиснення на продавця та відображення клієнтів, яких він обслуговував

        private void salesmenDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Shop currentShop = GetShop();
            UpdateClientsDT(currentShop.ListOfSalesmen[salesmenDV.CurrentCell.RowIndex]);
        }
        //Обробка натиснення на кнопку "Закрити магазин"
        private void closeShopButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви точно хочете закрити цей магазин?", "Закриття", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (shopsCB.SelectedItem == null)
                    {
                        throw new Exception();
                    }
                    clientShopCB.Items.Remove(GetShop().Address);
                    Shop.CloseShop(GetShop());
                    shopsCB.Items.Remove(shopsCB.SelectedItem);
                }
                catch(Exception)
                {
                    MessageBox.Show("Оберіть магазин, який хочете закрити!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                MessageBox.Show("Магазин закрито", "Магазин", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while(salesmenDV.Rows.Count!=0)
                {
                    salesmenDV.Rows.Remove(salesmenDV.Rows[0]);
                }
                if(Shop.ListOfShops.Count==0)
                {
                    UpdateNumbersOfProductsDT();
                }
            }
            else
            {
                return;
            }
            while(clientsDV.Rows.Count!=0)
            {
                clientsDV.Rows.Remove(clientsDV.Rows[0]);
            }
        }
        //Обробка натискання кнопки "Завершити роботу"
        private void closeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Будь ласка, перевірте, чи ви зберегли результат роботи програми", "Завершення роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var result = MessageBox.Show("Ви точно хочете завершити роботу програми?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }

        }
        //Обробка натискання кнопки "Зберегти всі зміни"
        private void savingButton_Click(object sender, EventArgs e)
        {
            SaveShopItemsInFile();
            SaveProductItemsInFile();
            MessageBox.Show("Дані збережено", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
