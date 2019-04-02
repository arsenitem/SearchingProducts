using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RoutesGMAP.AdminForm
{
    public partial class ShopsListAdmin : UserControl
    {
        public ShopsListAdmin()
        {
            InitializeComponent();
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var results = db.Shops.Join(db.ShopsAdress, // второй набор
                    p => p.Id, // свойство-селектор объекта из первого набора
                    c => c.Shop_id, // свойство-селектор объекта из второго набора
                    (p, c) => new
                    {
                        shop_name = p.ShopName,
                        shop_adress = c.ShopAdress,
                        shop_lat = c.ShopLatitude,
                        shop_lon = c.ShopLongitude
                    }).Where(x => x.shop_name == "Семья");
                foreach (var shop in results)
                {
                    SearchDataGrid.Rows.Add(shop.shop_name, shop.shop_adress);
                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e) //Добавить магазин
        {
            successLabel.Visible = false;
            SearchDataGrid.Rows.Add("Семья");
            for (int i=0;i<SearchDataGrid.Rows.Count;i++)
            {
                for (int j = 0; j < SearchDataGrid.Columns.Count; j++)
                {
                    SearchDataGrid.Rows[i].Cells[j].ReadOnly = true;
                }
            }
            SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[1].ReadOnly = false;
            SearchDataGrid.CurrentCell = SearchDataGrid.Rows[SearchDataGrid.Rows.Count - 1].Cells[1];
            SearchDataGrid.BeginEdit(true);
            
        }

        private void SearchDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e) 
        {
            try
            {
                if (SearchDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    using (SearchProductsEntities db = new SearchProductsEntities())
                    {
                        var res = db.ShopsAdress.Where(x => x.ShopAdress == SearchDataGrid.CurrentCell.Value.ToString()).FirstOrDefault();
                        if (res == null)
                        {
                            var shop_id = db.Shops.Where(x => x.ShopName == "Семья").Select(x => x.Id).FirstOrDefault();
                            ShopsAdress sa = new ShopsAdress();
                            sa.Shop_id = shop_id;
                            sa.ShopAdress = SearchDataGrid.CurrentCell.Value.ToString();
                            db.ShopsAdress.Add(sa);
                            db.SaveChanges();
                            successLabel.Text = "Адрес успешно добавлен";
                            successLabel.ForeColor = Color.ForestGreen;
                            successLabel.Visible = true;
                        }
                        else
                        {
                            successLabel.Visible = true;
                            successLabel.Text = "Адрес уже добавлен";
                            successLabel.ForeColor = Color.Red;
                            SearchDataGrid.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }

                else
                {
                    successLabel.Visible = true;
                    successLabel.Text = "Укажите адрес";
                    successLabel.ForeColor = Color.Red;
                    SearchDataGrid.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch { }
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            using (SearchProductsEntities db = new SearchProductsEntities())
            {
                var remove=db.ShopsAdress.Where(x => x.ShopAdress == SearchDataGrid.CurrentCell.Value.ToString()).FirstOrDefault();
                db.ShopsAdress.Remove(remove);
                db.SaveChanges();
            }
            successLabel.Visible = true;
            successLabel.Text = "Адрес удален";
            successLabel.ForeColor = Color.Red;
            SearchDataGrid.Rows.RemoveAt(SearchDataGrid.CurrentCell.RowIndex);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            SearchDataGrid.CurrentCell.ReadOnly = false;
        }
    }
}
