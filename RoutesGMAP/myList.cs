using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace RoutesGMAP
{
    public partial class myList : UserControl
    {
        public myList()
        {
            InitializeComponent();
            MyShopList.myshoplist.Add(new string[] { "Молоко Ашатли Деревенское 3.5%-4.5%", "1.4 л", "Семья", "99,90" });
            MyShopList.myshoplist.Add(new string[] { "Яйцо куриное Чебаркульская птица Домашнее 1 категория", "700 г", "Семья", "78,50" });
            MyShopList.myshoplist.Add(new string[] { "Сыр Almette творожный сливочный 60%", "150 г", "Пяторчка", "146,50" });
            MyShopList.myshoplist.Add(new string[] { "Масло сливочное Простоквашино 82%", "180 г", "Семья", "99,90" });
            MyShopList.myshoplist.Add(new string[] { "Рис Мистраль индика", "1 кг", "Пятерочка", "122,50" });
            for (int i = 0; i < MyShopList.myshoplist.Count; i++)
            {
                string[] s = MyShopList.myshoplist[i];
                MyListDataGrid.Rows.Add(i + 1, s[0], s[1], s[2], Convert.ToDecimal(s[3]));
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void TxtExport_Click(object sender, EventArgs e)
        {
            System.Threading.Thread export = new System.Threading.Thread(ExportTxt);
            export.Start();
        }

        private void WordExport_Click(object sender, EventArgs e)
        {
            System.Threading.Thread export = new System.Threading.Thread(ExportWord);
            export.Start();
        }

        private void ExcelExport_Click(object sender, EventArgs e)
        {
            
            System.Threading.Thread export = new System.Threading.Thread(ExportExcel);
            export.Start();
        }

        private void MyListDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                delLabel.Text = MyListDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + MyListDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString() + " удален из списка покупок";
                delLabel.Visible = true;
                MyListDataGrid.Rows.RemoveAt(e.RowIndex);
                MyShopList.myshoplist.RemoveAt(e.RowIndex);
                RefreshTable();
            }
        }
        private void ExportExcel()
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application(); //Новый экземпляр
            ExcelApp.Application.Workbooks.Add(Type.Missing); //Новая книга
            ExcelApp.Columns[1].ColumnWidth = 5;
            ExcelApp.Columns[2].ColumnWidth = 25;
            ExcelApp.Columns[3].ColumnWidth = 25;
            ExcelApp.Columns[4].ColumnWidth = 25;
            ExcelApp.Columns[5].ColumnWidth = 25;
            ExcelApp.Cells[1, 1] = "№";
            ExcelApp.Cells[1, 2] = "Товар";
            ExcelApp.Cells[1, 3] = "Объем";
            ExcelApp.Cells[1, 4] = "Магазин";
            ExcelApp.Cells[1, 5] = "Цена";
            for (int i = 0; i < MyListDataGrid.ColumnCount; i++)
            {
                for (int j = 0; j < MyListDataGrid.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (MyListDataGrid[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }
        private void ExportWord()
        {
            string template = AppDomain.CurrentDomain.BaseDirectory + "ShoppingList.docx";
            Microsoft.Office.Interop.Word.Application WordApp = new Microsoft.Office.Interop.Word.Application(); //Новый экземпляр
            var doc = WordApp.Documents.Open(template);
            doc.Tables.Add(doc.Paragraphs[2].Range, MyListDataGrid.Rows.Count, 5);
            Table tb1 = doc.Tables[1];
            tb1.Cell(1, 1).Range.Text = "№";
            tb1.Cell(1, 2).Range.Text = "Товар";
            tb1.Cell(1, 3).Range.Text = "Объем";
            tb1.Cell(1, 4).Range.Text = "Магазин";
            tb1.Cell(1, 5).Range.Text = "Цена";
            for (int i = 0; i < MyListDataGrid.ColumnCount; i++)
            {
                for (int j = 0; j < MyListDataGrid.RowCount; j++)
                {
                    tb1.Cell(j + 2, i + 1).Range.Text = MyListDataGrid[i, j].Value.ToString();
                }
            }
            WordApp.Visible = true;
        }
        private void ExportTxt()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "ShoppingList.txt";
            StreamWriter sw = new StreamWriter(path);
            for (int i = 0; i < MyListDataGrid.RowCount; i++)
            {
                string line_to_add = "";
                for (int j = 0; j < 5; j++)
                {
                    line_to_add += MyListDataGrid[j, i].Value.ToString() + "\t";
                }
                sw.WriteLine(line_to_add);
            }
            sw.Close();
            System.Diagnostics.Process.Start(path);
        }
        private void RefreshTable()
        {
            MyListDataGrid.Rows.Clear();
            for (int i = 0; i < MyShopList.myshoplist.Count; i++)
            {
                string[] s = MyShopList.myshoplist[i];
                MyListDataGrid.Rows.Add(i + 1, s[0], s[1], s[2], Convert.ToDecimal(s[3]));
            }
        }
    }
}
