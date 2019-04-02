using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoutesGMAP.AdminFormControls
{
    public partial class ProductsListAdmin : UserControl
    {
        public ProductsListAdmin()
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
                var results = from products in db.Products where products.ProductName.Contains(bunifuMetroTextbox1.Text)
                              join manufacturers in db.Manufacturer on products.ProductManufacturer equals manufacturers.Manufacturer_id
                              join categories in db.Categories on products.ProductCategory equals categories.Category_id
                              join prices in db.Prices on products.Product_id equals prices.Product_id
                              join shops in db.Shops on prices.Shop_id equals shops.Id where shops.ShopName=="Семья"
                              select new
                              {
                                  product_name = products.ProductName,
                                  product_category = categories.CategoryName,
                                  product_manufacturer = manufacturers.ManufacturerName,
                                  product_volume = products.ProductVolume,
                                  product_price = prices.ProductPrice
                              };
                #region Запрос не найден
                if (results.Count() == 0)
                {
                    errorLabel.Text = "По данному запросу ничего не найдено";
                    errorLabel.Visible = true;
                }
                #endregion

                #region Добавление в таблицу
                foreach (var res in results)
                {
                    SearchDataGrid.Rows.Add(res.product_name,res.product_category,res.product_manufacturer,res.product_volume,res.product_price);
                }
                #endregion
            }
            #endregion
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            SearchDataGrid.Rows.Add();
            for (int i = 0; i < SearchDataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < SearchDataGrid.Columns.Count; j++)
                {
                    SearchDataGrid.Rows[i].Cells[j].ReadOnly = true;
                }
            }
            //SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[0].ReadOnly = false;
            //SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[1].ReadOnly = false;
            //SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[2].ReadOnly = false;
            //SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[3].ReadOnly = false;
            //SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[4].ReadOnly = false;
           
            SearchDataGrid.CurrentCell = SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[0];
            SearchDataGrid.CurrentRow.ReadOnly = false;
            SearchDataGrid.BeginEdit(true);

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
            errorLabel.Visible = true;
            errorLabel.Text = "Товар удален";
            errorLabel.ForeColor = Color.Red;
            SearchDataGrid.Rows.RemoveAt(SearchDataGrid.CurrentCell.RowIndex);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SearchDataGrid.CurrentRow.ReadOnly = false;
        }
    }
}
