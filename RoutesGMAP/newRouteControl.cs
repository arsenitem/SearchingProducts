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
    public partial class newRouteControl : UserControl
    {
        public newRouteControl()
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

        private void getRoute_Click(object sender, EventArgs e)
        {
          
            var route = GoogleMapProvider.Instance.GetRoute(new PointLatLng(58.01625927, 56.27706885), new PointLatLng(58.00714, 56.2618428), false, true, 15);
           // var route2 = GoogleMapProvider.Instance.GetRoute(new PointLatLng(58.0126125, 56.2819628), new PointLatLng(58.0126346, 56.2819628), false, true, 15);
            var r = new GMapRoute(route.Points, "first");
          //  var r2 = new GMapRoute(route2.Points, "second");
            var route_overlay = new GMapOverlay();
            route_overlay.Routes.Add(r);
            //route_overlay.Routes.Add(r2);
            gMapControl1.Overlays.Add(route_overlay);
            gMapControl1.Zoom = 15;
        }
    }
}
