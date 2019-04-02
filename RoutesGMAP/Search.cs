using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesGMAP
{
    public partial class Search : UserControl
    {
        public Search()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchDataGrid.Rows.Clear();
            errorLabel.Visible = false;
            successLabel.Visible = true;
            string product_to_search = bunifuMetroTextbox1.Text;
            #region Обработка ввода пустых строк
            if (String.IsNullOrEmpty(product_to_search)) //Проверка на ввод пустых значений
            {
                errorLabel.Text = "Введите название товара";
                errorLabel.Visible = true;
                return;
            }
            #endregion

            #region Запрос к БД на поиск            
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var results = db.Products.Join(db.Prices, // второй набор
                    p => p.Product_id, // свойство-селектор объекта из первого набора
                    c => c.Product_id, // свойство-селектор объекта из второго набора
                    (p, c) => new
                    {
                        volume = p.ProductVolume,
                        name = p.ProductName,
                        shop = c.Shop_id,
                        price = c.ProductPrice

                    }).Where(x => x.name.Contains(product_to_search));

                #region Запрос не найден
                if (results.Count() == 0)
                {
                    errorLabel.Text = "По данному запросу ничего не найдено";
                    errorLabel.Visible = true;
                }
                #endregion

                #region Добавление в таблицу
                int row_number = 1;
                foreach (var res in results)
                {

                    var shop = db.Shops.Where(x => x.Id == res.shop).Select(x => x.ShopName);
                    foreach (var f in shop)
                    {
                        SearchDataGrid.Rows.Add(row_number, res.name, res.volume, f.ToString(), res.price.ToString());
                    }
                    row_number++;
                }
                #endregion
            }
            #endregion
        }

        private void SearchDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                MyShopList.myshoplist.Add(new string[] { SearchDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString(), SearchDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString(), SearchDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString(), SearchDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString() });
                successLabel.Text = SearchDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + SearchDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString() + " добавлен в список покупок";
                successLabel.Visible = true;
            }
        }
       
    }
    public static class MyShopList
    {
        public static List<string[]> myshoplist = new List<string[]>();
    }
}
