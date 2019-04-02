using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using RoutesGMAP;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace RoutesGMAP
{
    public partial class ShopsUserControl : UserControl
    {
        public ShopsUserControl()
        {
            InitializeComponent();
            gMapControl1.ShowCenter = false;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.CanDragMap = true;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.DragButton = MouseButtons.Left;
            GoogleMapProvider.Language = LanguageType.Russian;
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCyUssDzzAFVD5sqSoy-X_L5fEvC-JyMhU";
            gMapControl1.MapProvider = GMapProviders.GoogleMap;

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
                    });
                foreach (var shop in results)
                {
                    SearchDataGrid.Rows.Add(shop.shop_name, shop.shop_adress);
                }
            }
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 16;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.Position = new PointLatLng(58.01625927, 56.27706885);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(58.01625927, 56.27706885), GMarkerGoogleType.red);

            GMapOverlay overlay = new GMapOverlay("markers");
            overlay.Markers.Add(marker);

            gMapControl1.Overlays.Add(overlay);

           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(98, 32);
            panel1.Width = 138;
            panel2.Hide();
            panel3.Show();
           

        }
        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 32);
            panel1.Width = 89;
            panel3.Hide();
            panel2.Show();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
         
           if( gMapControl1.Overlays.Count>1) gMapControl1.Overlays.RemoveAt(1);
          
            string[] r = bunifuDropdown1.selectedValue.Split(' ');
            RadiusChanged(Convert.ToInt32(r[0]));
        }
        private void RadiusChanged(int radius)
        {
            DisplayShopsOnMap(radius);
        }
        private void DisplayShopsOnMap(double radius)
        {   
           GMapOverlay shop_overlay = new GMapOverlay("Shops");
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
                    });
                try
                {
                    foreach (var shop in results)
                    {
                        var distance = ComputeDistance((double)shop.shop_lat, (double)shop.shop_lon);
                        if (distance <= radius)
                        {
                            PointLatLng point = new PointLatLng((double)shop.shop_lat, (double)shop.shop_lon);

                            GMarkerGoogle marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                            shop_overlay.Markers.Add(marker);
                        }
                    }




                }
                catch { }
            }
                gMapControl1.Overlays.Add(shop_overlay);
               gMapControl1.Zoom = 14;
        }
        private double ComputeDistance(double lat, double lon)
        {
            var route = GoogleMapProvider.Instance.GetRoute(new PointLatLng(58.01625927, 56.27706885), new PointLatLng(lat, lon), false, true, 15);
            return route.Distance;
        }

       
    }
}
