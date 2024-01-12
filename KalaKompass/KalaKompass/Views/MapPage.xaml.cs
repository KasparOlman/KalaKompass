using Microsoft.Maui.Controls;
using System.Collections.Generic;

namespace KalaKompass.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            double latitude = 58.885381;
            double longitude = 25.549918;
            string apiKey = "AIzaSyBz1eES6CyIBLu2KAt92nQtmDzYOa9Dsj8";

            // Sample pin data
            var pin1 = new PinData { Latitude = 58.120553, Longitude = 24.304987, Label = "Liivi Laht", Info = "Liigid:" };
            var pin2 = new PinData { Latitude = 59.665660, Longitude = 25.259910, Label = "Soome laht", Info = "Liigid:" };
            var pin3 = new PinData { Latitude = 58.770115, Longitude = 27.396407, Label = "Peipsi järv", Info = "Liigid:" };
            var pin4 = new PinData { Latitude = 58.661988, Longitude = 21.815354, Label = "Läänemeri", Info = "Liigid:" };
            var pin5 = new PinData { Latitude = 58.296336, Longitude = 26.018214, Label = "Võrtsjärv", Info = "Liigid:" };
            var pin6 = new PinData { Latitude = 59.112723, Longitude = 25.351912, Label = "Paunküla veehoidla", Info = "Liigid:" };

            var htmlContent = GenerateHtmlContent(apiKey, latitude, longitude, pin1, pin2, pin3, pin4, pin5, pin6);

            googleMapView.Source = new HtmlWebViewSource { Html = htmlContent };
        }

        private string GenerateHtmlContent(string apiKey, double centerLatitude, double centerLongitude, params PinData[] pins)
        {
            var jsMarkers = string.Join("", pins.Select(pin =>
                $@"addMarker({pin.Latitude}, {pin.Longitude}, '{pin.Label}', '{pin.Info}');"));

            return $@"<html>
                        <body>
                            <div id='map' style='width: 100%; height: 100%;'></div>
                            <script async defer
                                    src='https://maps.googleapis.com/maps/api/js?key={apiKey}&callback=initMap'>
                            </script>
                            <script>
                                function initMap() {{
                                    var map = new google.maps.Map(document.getElementById('map'), {{
                                        center: {{lat: {centerLatitude}, lng: {centerLongitude}}},
                                        zoom: 6,
                                        mapTypeId: 'satellite'
                                    }});

                                    // Global array to store markers
                                    var markers = [];

                                    // Function to add a marker
                                    function addMarker(lat, lng, label, info) {{
                                        var marker = new google.maps.Marker({{
                                            position: {{lat: lat, lng: lng}},
                                            map: map,
                                            title: label
                                        }});

                                        var infowindow = new google.maps.InfoWindow({{
                                            content: '<div><strong>' + label + '</strong></div><div>' + info + '</div>'
                                        }});

                                        // Event listener to open the info window when marker is clicked
                                        marker.addListener('click', function() {{
                                            infowindow.open(map, marker);
                                        }});

                                        markers.push(marker);
                                    }}

                                    // Example of adding pins
                                    {jsMarkers}
                                }}
                            </script>
                        </body>
                    </html>";
        }

        // Sample class for pin data
        private class PinData
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
            public string Label { get; set; }
            public string Info { get; set; }
        }
    }
}
